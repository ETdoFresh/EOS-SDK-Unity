// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Input parameters for the <see cref="UIInterface.GetToggleFriendsKey" /> function.
	/// </summary>
	public struct GetToggleFriendsKeyOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetToggleFriendsKeyOptionsInternal : ISettable<GetToggleFriendsKeyOptions>, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ref GetToggleFriendsKeyOptions other)
		{
			m_ApiVersion = UIInterface.GettogglefriendskeyApiLatest;
		}

		public void Set(ref GetToggleFriendsKeyOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = UIInterface.GettogglefriendskeyApiLatest;
			}
		}

		public void Dispose()
		{
		}
	}
}