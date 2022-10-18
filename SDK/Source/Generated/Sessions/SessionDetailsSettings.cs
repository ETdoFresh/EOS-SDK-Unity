// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Common settings associated with a single session
	/// </summary>
	public struct SessionDetailsSettings
	{
		/// <summary>
		/// The main indexed parameter for this session, can be any string (i.e. "Region:GameMode")
		/// </summary>
		public Utf8String BucketId { get; set; }

		/// <summary>
		/// Number of total players allowed in the session
		/// </summary>
		public uint NumPublicConnections { get; set; }

		/// <summary>
		/// Are players allowed to join the session while it is in the "in progress" state
		/// </summary>
		public bool AllowJoinInProgress { get; set; }

		/// <summary>
		/// Permission level describing allowed access to the session when joining or searching for the session
		/// </summary>
		public OnlineSessionPermissionLevel PermissionLevel { get; set; }

		/// <summary>
		/// Are players allowed to send invites for the session
		/// </summary>
		public bool InvitesAllowed { get; set; }

		/// <summary>
		/// Are sanctioned players allowed to join - sanctioned players will be rejected if set to true
		/// </summary>
		public bool SanctionsEnabled { get; set; }

		internal void Set(ref SessionDetailsSettingsInternal other)
		{
			BucketId = other.BucketId;
			NumPublicConnections = other.NumPublicConnections;
			AllowJoinInProgress = other.AllowJoinInProgress;
			PermissionLevel = other.PermissionLevel;
			InvitesAllowed = other.InvitesAllowed;
			SanctionsEnabled = other.SanctionsEnabled;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct SessionDetailsSettingsInternal : IGettable<SessionDetailsSettings>, ISettable<SessionDetailsSettings>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_BucketId;
		private uint m_NumPublicConnections;
		private int m_AllowJoinInProgress;
		private OnlineSessionPermissionLevel m_PermissionLevel;
		private int m_InvitesAllowed;
		private int m_SanctionsEnabled;

		public Utf8String BucketId
		{
			get
			{
				Utf8String value;
				Helper.Get(m_BucketId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_BucketId);
			}
		}

		public uint NumPublicConnections
		{
			get
			{
				return m_NumPublicConnections;
			}

			set
			{
				m_NumPublicConnections = value;
			}
		}

		public bool AllowJoinInProgress
		{
			get
			{
				bool value;
				Helper.Get(m_AllowJoinInProgress, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AllowJoinInProgress);
			}
		}

		public OnlineSessionPermissionLevel PermissionLevel
		{
			get
			{
				return m_PermissionLevel;
			}

			set
			{
				m_PermissionLevel = value;
			}
		}

		public bool InvitesAllowed
		{
			get
			{
				bool value;
				Helper.Get(m_InvitesAllowed, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_InvitesAllowed);
			}
		}

		public bool SanctionsEnabled
		{
			get
			{
				bool value;
				Helper.Get(m_SanctionsEnabled, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_SanctionsEnabled);
			}
		}

		public void Set(ref SessionDetailsSettings other)
		{
			m_ApiVersion = SessionDetails.SessiondetailsSettingsApiLatest;
			BucketId = other.BucketId;
			NumPublicConnections = other.NumPublicConnections;
			AllowJoinInProgress = other.AllowJoinInProgress;
			PermissionLevel = other.PermissionLevel;
			InvitesAllowed = other.InvitesAllowed;
			SanctionsEnabled = other.SanctionsEnabled;
		}

		public void Set(ref SessionDetailsSettings? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = SessionDetails.SessiondetailsSettingsApiLatest;
				BucketId = other.Value.BucketId;
				NumPublicConnections = other.Value.NumPublicConnections;
				AllowJoinInProgress = other.Value.AllowJoinInProgress;
				PermissionLevel = other.Value.PermissionLevel;
				InvitesAllowed = other.Value.InvitesAllowed;
				SanctionsEnabled = other.Value.SanctionsEnabled;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_BucketId);
		}

		public void Get(out SessionDetailsSettings output)
		{
			output = new SessionDetailsSettings();
			output.Set(ref this);
		}
	}
}