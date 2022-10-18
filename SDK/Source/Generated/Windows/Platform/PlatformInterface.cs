// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Platform
{
	public sealed partial class PlatformInterface : Handle
	{
		/// <summary>
		/// The most recent version of the <see cref="WindowsRTCOptionsPlatformSpecificOptions" /> structure.
		/// </summary>
		public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;

		public static PlatformInterface Create(ref WindowsOptions options)
		{
			WindowsOptionsInternal optionsInternal = new WindowsOptionsInternal();
			optionsInternal.Set(ref options);

			var funcResult = WindowsBindings.EOS_Platform_Create(ref optionsInternal);

			Helper.Dispose(ref optionsInternal);

			PlatformInterface funcResultReturn;
			Helper.Get(funcResult, out funcResultReturn);
			return funcResultReturn;
		}
	}
}