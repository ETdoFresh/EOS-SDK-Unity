// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	public struct LobbyDetailsInfo
	{
		/// <summary>
		/// Lobby ID
		/// </summary>
		public Utf8String LobbyId { get; set; }

		/// <summary>
		/// The Product User ID of the current owner of the lobby
		/// </summary>
		public ProductUserId LobbyOwnerUserId { get; set; }

		/// <summary>
		/// Permission level of the lobby
		/// </summary>
		public LobbyPermissionLevel PermissionLevel { get; set; }

		/// <summary>
		/// Current available space
		/// </summary>
		public uint AvailableSlots { get; set; }

		/// <summary>
		/// Max allowed members in the lobby
		/// </summary>
		public uint MaxMembers { get; set; }

		/// <summary>
		/// If true, users can invite others to this lobby
		/// </summary>
		public bool AllowInvites { get; set; }

		/// <summary>
		/// The main indexed parameter for this lobby, can be any string (i.e. "Region:GameMode")
		/// </summary>
		public Utf8String BucketId { get; set; }

		/// <summary>
		/// Is host migration allowed
		/// </summary>
		public bool AllowHostMigration { get; set; }

		/// <summary>
		/// Was a Real-Time Communication (RTC) room enabled at lobby creation?
		/// </summary>
		public bool RTCRoomEnabled { get; set; }

		/// <summary>
		/// Is <see cref="LobbyInterface.JoinLobbyById" /> allowed
		/// </summary>
		public bool AllowJoinById { get; set; }

		/// <summary>
		/// Does rejoining after being kicked require an invite
		/// </summary>
		public bool RejoinAfterKickRequiresInvite { get; set; }

		internal void Set(ref LobbyDetailsInfoInternal other)
		{
			LobbyId = other.LobbyId;
			LobbyOwnerUserId = other.LobbyOwnerUserId;
			PermissionLevel = other.PermissionLevel;
			AvailableSlots = other.AvailableSlots;
			MaxMembers = other.MaxMembers;
			AllowInvites = other.AllowInvites;
			BucketId = other.BucketId;
			AllowHostMigration = other.AllowHostMigration;
			RTCRoomEnabled = other.RTCRoomEnabled;
			AllowJoinById = other.AllowJoinById;
			RejoinAfterKickRequiresInvite = other.RejoinAfterKickRequiresInvite;
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyDetailsInfoInternal : IGettable<LobbyDetailsInfo>, ISettable<LobbyDetailsInfo>, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LobbyId;
		private System.IntPtr m_LobbyOwnerUserId;
		private LobbyPermissionLevel m_PermissionLevel;
		private uint m_AvailableSlots;
		private uint m_MaxMembers;
		private int m_AllowInvites;
		private System.IntPtr m_BucketId;
		private int m_AllowHostMigration;
		private int m_RTCRoomEnabled;
		private int m_AllowJoinById;
		private int m_RejoinAfterKickRequiresInvite;

		public Utf8String LobbyId
		{
			get
			{
				Utf8String value;
				Helper.Get(m_LobbyId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LobbyId);
			}
		}

		public ProductUserId LobbyOwnerUserId
		{
			get
			{
				ProductUserId value;
				Helper.Get(m_LobbyOwnerUserId, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_LobbyOwnerUserId);
			}
		}

		public LobbyPermissionLevel PermissionLevel
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

		public uint AvailableSlots
		{
			get
			{
				return m_AvailableSlots;
			}

			set
			{
				m_AvailableSlots = value;
			}
		}

		public uint MaxMembers
		{
			get
			{
				return m_MaxMembers;
			}

			set
			{
				m_MaxMembers = value;
			}
		}

		public bool AllowInvites
		{
			get
			{
				bool value;
				Helper.Get(m_AllowInvites, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AllowInvites);
			}
		}

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

		public bool AllowHostMigration
		{
			get
			{
				bool value;
				Helper.Get(m_AllowHostMigration, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AllowHostMigration);
			}
		}

		public bool RTCRoomEnabled
		{
			get
			{
				bool value;
				Helper.Get(m_RTCRoomEnabled, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_RTCRoomEnabled);
			}
		}

		public bool AllowJoinById
		{
			get
			{
				bool value;
				Helper.Get(m_AllowJoinById, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_AllowJoinById);
			}
		}

		public bool RejoinAfterKickRequiresInvite
		{
			get
			{
				bool value;
				Helper.Get(m_RejoinAfterKickRequiresInvite, out value);
				return value;
			}

			set
			{
				Helper.Set(value, ref m_RejoinAfterKickRequiresInvite);
			}
		}

		public void Set(ref LobbyDetailsInfo other)
		{
			m_ApiVersion = LobbyDetails.LobbydetailsInfoApiLatest;
			LobbyId = other.LobbyId;
			LobbyOwnerUserId = other.LobbyOwnerUserId;
			PermissionLevel = other.PermissionLevel;
			AvailableSlots = other.AvailableSlots;
			MaxMembers = other.MaxMembers;
			AllowInvites = other.AllowInvites;
			BucketId = other.BucketId;
			AllowHostMigration = other.AllowHostMigration;
			RTCRoomEnabled = other.RTCRoomEnabled;
			AllowJoinById = other.AllowJoinById;
			RejoinAfterKickRequiresInvite = other.RejoinAfterKickRequiresInvite;
		}

		public void Set(ref LobbyDetailsInfo? other)
		{
			if (other.HasValue)
			{
				m_ApiVersion = LobbyDetails.LobbydetailsInfoApiLatest;
				LobbyId = other.Value.LobbyId;
				LobbyOwnerUserId = other.Value.LobbyOwnerUserId;
				PermissionLevel = other.Value.PermissionLevel;
				AvailableSlots = other.Value.AvailableSlots;
				MaxMembers = other.Value.MaxMembers;
				AllowInvites = other.Value.AllowInvites;
				BucketId = other.Value.BucketId;
				AllowHostMigration = other.Value.AllowHostMigration;
				RTCRoomEnabled = other.Value.RTCRoomEnabled;
				AllowJoinById = other.Value.AllowJoinById;
				RejoinAfterKickRequiresInvite = other.Value.RejoinAfterKickRequiresInvite;
			}
		}

		public void Dispose()
		{
			Helper.Dispose(ref m_LobbyId);
			Helper.Dispose(ref m_LobbyOwnerUserId);
			Helper.Dispose(ref m_BucketId);
		}

		public void Get(out LobbyDetailsInfo output)
		{
			output = new LobbyDetailsInfo();
			output.Set(ref this);
		}
	}
}