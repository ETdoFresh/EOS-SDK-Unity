// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="LobbyInterface.QueryInvites" />
	/// </summary>
	/// <param name="data">A <see cref="LobbyInterface.QueryInvites" /> CallbackInfo containing the output information and result</param>
	public delegate void OnQueryInvitesCallback(ref QueryInvitesCallbackInfo data);

	[System.Runtime.InteropServices.UnmanagedFunctionPointer(Config.LibraryCallingConvention)]
	internal delegate void OnQueryInvitesCallbackInternal(ref QueryInvitesCallbackInfoInternal data);
}