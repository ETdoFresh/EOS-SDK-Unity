// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="ConnectInterface.UnlinkAccount" />.
	/// </summary>
	/// <param name="data">A <see cref="UnlinkAccountCallbackInfo" /> containing the output information and result</param>
	public delegate void OnUnlinkAccountCallback(ref UnlinkAccountCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnUnlinkAccountCallbackInternal(ref UnlinkAccountCallbackInfoInternal data);
}