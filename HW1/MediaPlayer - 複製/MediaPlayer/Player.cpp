// Multimedia_HW1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

IGraphBuilder *pGraph;
IMediaControl *pControl;
IMediaEventEx *pEventEx;
IMediaSeeking *pSeek;
HWND hScroll;

void ShowError(HRESULT hr)
{
    if (FAILED(hr))
    {
		TCHAR szErr[MAX_ERROR_TEXT_LEN] = {0};
        DWORD res = AMGetErrorText(hr, szErr, MAX_ERROR_TEXT_LEN);
        if (res == 0)
        {
            StringCchPrintf(szErr, MAX_ERROR_TEXT_LEN, TEXT("Unknown Error: 0x%2x"), hr);
        }
        throw szErr;
    }
}
bool GetCompletionEvent()
{
	if (pEventEx == NULL)
	{
		return false;
	}

	while (true)
	{
		long evCode;
		LONG_PTR param1, param2;
		HRESULT hr = pEventEx->GetEvent(&evCode, &param1, &param2, 0);
		if (FAILED(hr))
		{
			return false;
		}

		hr = pEventEx->FreeEventParams(evCode, param1, param2);
		ShowError(hr);

		if (evCode == EC_COMPLETE)
		{
			return true;
		}
	}
}

//void InitSlider(HWND hwnd)
//{
//    // Initialize the trackbar range, but disable the control until the user opens a file.
//    hScroll = GetDlgItem(hwnd, 1);
//    EnableWindow(hScroll, FALSE);
//    SendMessage(hScroll, TBM_SETRANGE, TRUE, MAKELONG(0, 100));
//}

void Stop(void)
{
	if (pGraph)
	{
		pGraph->Release();
		pGraph = NULL;
	}
	if (pControl)
	{
		pControl->Release();
		pControl = NULL;
	}
	if (pEventEx)
	{
		pEventEx->SetNotifyWindow((OAHWND)NULL, WM_GRAPHNOTIFY, 0);
		pEventEx->Release();
		pEventEx = NULL;
	}
	if (pSeek)
	{
		pSeek->Release();
		pSeek = NULL;
	}
	CoUninitialize();
}

DWORD WINAPI Play(LPVOID lpThreadParameter)
{
	HRESULT hr;

	try
	{
		if (pGraph)
			return 0;
    // Initialize the COM library.
		hr = CoInitialize(NULL);
		ShowError(hr);

    // Create the filter graph manager and query for interfaces.
		hr = CoCreateInstance(CLSID_FilterGraph, NULL, CLSCTX_INPROC_SERVER, IID_IGraphBuilder, (void **)&pGraph);
		ShowError(hr);

		// Build the graph. IMPORTANT: Change this string to a file on your system.
		hr = pGraph->RenderFile(L"C:\\Users\\user\\Downloads\\test2.avi", NULL);
		ShowError(hr);

		hr = pGraph->QueryInterface(IID_IMediaControl, (void **)&pControl);
		ShowError(hr);

		// Run the graph.
		hr = pControl->Run();
		ShowError(hr);

		hr = pGraph->QueryInterface(IID_IMediaEventEx, (void **)&pEventEx);
		ShowError(hr);

		hr = pGraph->QueryInterface(IID_IMediaSeeking, (void**)&pSeek);
		ShowError(hr);

		/*#define ONE_SECOND 10000000
		REFERENCE_TIME rtNow  = 2 * ONE_SECOND, 
					   rtStop = 5 * ONE_SECOND;

		hr = pSeek->SetPositions(
			&rtNow,  AM_SEEKING_AbsolutePositioning, 
			&rtStop, AM_SEEKING_AbsolutePositioning
			);*/

		// Determine if the source is seekable.
		BOOL  bCanSeek = FALSE;
		long long g_rtTotalTime;
		DWORD caps = AM_SEEKING_CanSeekAbsolute | AM_SEEKING_CanGetDuration; 
		bCanSeek = (S_OK == pSeek->CheckCapabilities(&caps));
		if (bCanSeek)
		{
			// Enable the trackbar.
			EnableWindow(hScroll, TRUE);

			// Find the file duration.
			hr = pSeek->GetDuration(&g_rtTotalTime);
			ShowError(hr);
		}

		hr = pSeek->IsFormatSupported(&TIME_FORMAT_FRAME);
		if (hr == S_OK)
		{
			hr = pSeek->SetTimeFormat(&TIME_FORMAT_FRAME);
			if (SUCCEEDED(hr))
			{
				// Seek to frame number 20.
				LONGLONG rtNow = 20;
				hr = pSeek->SetPositions(
					&rtNow, AM_SEEKING_AbsolutePositioning, 
					0, AM_SEEKING_NoPositioning);
			}
		}

		//set rate
		hr = pSeek->SetRate(1.0);
		ShowError(hr);

		/*HWND hwnd = (HWND)lpThreadParameter;
		hr = pEventEx->SetNotifyWindow((OAHWND)hwnd, WM_GRAPHNOTIFY, 0);
		ShowError(hr);*/

		HANDLE  hEvent; 
		hr = pEventEx->GetEventHandle((OAEVENT*)&hEvent);
		ShowError(hr);
		
		BOOLEAN bDone = FALSE;
		
		while(!bDone) 
		{
			if (WAIT_OBJECT_0 == WaitForSingleObject(hEvent, INFINITE))
			{
				long    evCode, param1, param2;
				while (S_OK == pEventEx->GetEvent(&evCode, &param1, &param2, 0)) 
				{
					printf("Event code: %#04x\n Params: %d, %d\n", evCode, param1, param2);
					pEventEx->FreeEventParams(evCode, param1, param2);
					bDone = (EC_COMPLETE == evCode);
				}
			}
		}

		
		// Wait for completion.
		/*long evCode;
		hr = pEventEx->WaitForCompletion(INFINITE, &evCode);
		ShowError(hr);*/
        // Note: Do not use INFINITE in a real application, because it can block indefinitely.
		
	}
	catch(TCHAR szErr[])
	{
		MessageBox(NULL, (LPCTSTR)szErr, TEXT("DirectShow Application"), 0);
	}
}

void BeginPlay(HWND hwnd)
{
	HANDLE hThread = CreateThread(NULL, 0, Play, hwnd, 0, NULL);
}