// NativeSizes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#include <Dbt.h>
#include <CommCtrl.h>
#include <Uxtheme.h>
#include <dwmapi.h>
#include <wincred.h>

using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	cout << "Native value sizes:" << endl;
	cout << "BYTE = " << sizeof(BYTE) << endl;
	cout << "BOOL = " << sizeof(BOOL) << endl;
	cout << "WORD = " << sizeof(WORD) << endl;
	cout << "DWORD = " << sizeof(DWORD) << endl;
	cout << "UINT = " << sizeof(UINT) << endl;
	cout << "LONG = " << sizeof(LONG) << endl;
	cout << "LONGLONG = " << sizeof(LONGLONG) << endl;

	cout << endl;

	cout << "APPBARDATA = " << sizeof(APPBARDATA) << endl;
	cout << "BITMAPINFO = " << sizeof(BITMAPINFO) << endl;
	cout << "BITMAPINFOHEADER = " << sizeof(BITMAPINFOHEADER) << endl;
	cout << "BLENDFUNCTION = " << sizeof(BLENDFUNCTION) << endl;
	cout << "COMBOBOXINFO = " << sizeof(COMBOBOXINFO) << endl;
	cout << "DEV_BROADCAST_DEVICEINTERFACE = " << sizeof(DEV_BROADCAST_DEVICEINTERFACE) << endl;
	cout << "DEV_BROADCAST_HANDLE = " << sizeof(DEV_BROADCAST_HANDLE) << endl;
	cout << "DEV_BROADCAST_HDR = " << sizeof(DEV_BROADCAST_HDR) << endl;
	cout << "DEV_BROADCAST_OEM = " << sizeof(DEV_BROADCAST_OEM) << endl;
	cout << "DEV_BROADCAST_PORT = " << sizeof(DEV_BROADCAST_PORT) << endl;
	cout << "DEV_BROADCAST_VOLUME = " << sizeof(DEV_BROADCAST_VOLUME) << endl;
	cout << "HRESULT = " << sizeof(HRESULT) << endl;
	cout << "LVCOLUMN = " << sizeof(LVCOLUMN) << endl;
	cout << "LVGROUP = " << sizeof(LVGROUP) << endl;
	cout << "LVITEM = " << sizeof(LVITEM) << endl;
	cout << "MARGINS = " << sizeof(MARGINS) << endl;

	cout << "MINMAXINFO = " << sizeof(MINMAXINFO) << endl;
	cout << "MONITORINFO = " << sizeof(MONITORINFO) << endl;
	cout << "NCCALCSIZE_PARAMS = " << sizeof(NCCALCSIZE_PARAMS) << endl;
	cout << "POINT = " << sizeof(POINT) << endl;
	cout << "RECT = " << sizeof(RECT) << endl;
	cout << "RGBQUAD = " << sizeof(RGBQUAD) << endl;
	cout << "SIZE = " << sizeof(SIZE) << endl;
	cout << "TRACKMOUSEEVENT = " << sizeof(TRACKMOUSEEVENT) << endl;
	cout << "WINDOWPLACEMENT = " << sizeof(WINDOWPLACEMENT) << endl;
	cout << "WINDOWPOS = " << sizeof(WINDOWPOS) << endl;
	cin.get();
	return 0;
}

