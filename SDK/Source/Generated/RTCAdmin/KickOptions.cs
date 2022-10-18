// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAdmin
{
	/// <summary>
	/// Input parameters for the <see cref="RTCAdminInterface.Kick" /> function.
	/// </summary>
	public struct KickOptions
	{
		/// <summary>
		/// Room name to kick the participant from
		/// </summary>
		public Utf8String RoomName { get; set; }

		/// <summary>
		/// Product User ID of the participant to kick from the room
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct KickOptionsInternal : ISettable<KickOptions>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_TargetUserId;

		public Utf8String RoomName
		{
			set
			{
				Helper.Set(value, ref m_RoomName);
			}
		}

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.Set(value, ref m_TargetUserId);
			}
		}

		public void Set(ref KickOptions other)
		{
			m_ApiVersion = RTCAdminInterface.KickApiLatest;
			RoomName = other.RoomName;
			TargetUserId = other.TargetUserId;
		}

		public void Set(ref KickOptions? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = RTCAdminInterface.KickApiLatest;
				RoomName = other.Value.RoomName;
				TargetUserId = other.Value.TargetUserId;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_RoomName);
			Helper.Dispose(ref m_TargetUserId);
		}
	}
}