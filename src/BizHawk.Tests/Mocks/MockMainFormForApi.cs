﻿using System;
using System.Drawing;

using BizHawk.Client.Common;
using BizHawk.Emulation.Common;

namespace BizHawk.Tests.Mocks
{
	internal class MockMainFormForApi : IMainFormForApi
	{
		public (HttpCommunication HTTP, MemoryMappedFiles MMF, SocketServer Sockets) NetworkingHelpers => (null!, null!, null!);

		public IEmulator Emulator { get; }

		public IMovieSession MovieSession => null!;

		public IToolManager Tools => null!;

		public MockMainFormForApi(IEmulator emulator)
		{
			Emulator = emulator;
		}


		// Everything below here is not implemented.
		public CheatCollection CheatList => throw new NotImplementedException();

		public Point DesktopLocation => throw new NotImplementedException();

		public bool EmulatorPaused => throw new NotImplementedException();

		public bool InvisibleEmulation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public bool IsSeeking => throw new NotImplementedException();

		public bool IsTurboing => throw new NotImplementedException();

		public bool PauseAvi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void ClearHolds() => throw new NotImplementedException();
		public void ClickSpeedItem(int num) => throw new NotImplementedException();
		public void CloseEmulator(int? exitCode = null) => throw new NotImplementedException();
		public void CloseRom(bool clearSram = false) => throw new NotImplementedException();
		public void EnableRewind(bool enabled) => throw new NotImplementedException();
		public bool FlushSaveRAM(bool autosave = false) => throw new NotImplementedException();
		public void FrameAdvance() => throw new NotImplementedException();
		public void FrameBufferResized() => throw new NotImplementedException();
		public void FrameSkipMessage() => throw new NotImplementedException();
		public int GetApproxFramerate() => throw new NotImplementedException();
		public bool LoadMovie(string filename, string? archive = null) => throw new NotImplementedException();
		public bool LoadQuickSave(int slot, bool suppressOSD = false) => throw new NotImplementedException();
		public bool LoadRom(string path, LoadRomArgs args) => throw new NotImplementedException();
		public bool LoadState(string path, string userFriendlyStateName, bool suppressOSD = false) => throw new NotImplementedException();
		public void PauseEmulator() => throw new NotImplementedException();
		public bool RebootCore() => throw new NotImplementedException();
		public void Render() => throw new NotImplementedException();
		public bool RestartMovie() => throw new NotImplementedException();
		public void SaveQuickSave(int slot, bool suppressOSD = false, bool fromLua = false) => throw new NotImplementedException();
		public void SaveState(string path, string userFriendlyStateName, bool fromLua = false, bool suppressOSD = false) => throw new NotImplementedException();
		public void SeekFrameAdvance() => throw new NotImplementedException();
		public void StepRunLoop_Throttle() => throw new NotImplementedException();
		public void StopMovie(bool saveChanges = true) => throw new NotImplementedException();
		public void TakeScreenshot() => throw new NotImplementedException();
		public void TakeScreenshot(string path) => throw new NotImplementedException();
		public void TakeScreenshotToClipboard() => throw new NotImplementedException();
		public void TogglePause() => throw new NotImplementedException();
		public void ToggleSound() => throw new NotImplementedException();
		public void UnpauseEmulator() => throw new NotImplementedException();
	}
}
