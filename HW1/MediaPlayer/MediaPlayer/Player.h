#include <dshow.h>

#define WM_GRAPHNOTIFY WM_APP + 1   // Private message.

void BeginPlay(HWND hwnd);
//DWORD Play(LPVOID lpThreadParameter);
void Stop();
bool GetCompletionEvent();