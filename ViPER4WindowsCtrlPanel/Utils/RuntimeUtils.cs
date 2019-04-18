using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ViPER4WindowsBin.Utils
{
	// Token: 0x02000027 RID: 39
	public class RuntimeUtils
	{
		// Token: 0x02000028 RID: 40
		public class GeneralUtils
		{
			// Token: 0x060001FB RID: 507 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
			public static string CharArrayToString(char[] caArray)
			{
				string text = new string(caArray);
				if (string.IsNullOrEmpty(text))
				{
					return "";
				}
				char[] array = text.ToCharArray();
				int num = -1;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == '\0')
					{
						num = i;
						break;
					}
				}
				if (num == -1)
				{
					return "";
				}
				char[] array2 = new char[num];
				Array.Copy(array, array2, num);
				text = new string(array2);
				if (string.IsNullOrEmpty(text))
				{
					return "";
				}
				return text;
			}
		}

		// Token: 0x02000029 RID: 41
		public class EqualizerUtils
		{
			// Token: 0x060001FD RID: 509
			[DllImport("Utils.dll")]
			private static extern void EstimateEqualizer(float[] rpEQBands, IntPtr rpResponses, ref int ipResponseLength, int nBandCount, int nWindow, int nType);

			// Token: 0x060001FE RID: 510 RVA: 0x0001BF6C File Offset: 0x0001A16C
			public static float[] EstimateEqualizerResponse(float[] rpEQBands)
			{
				if (rpEQBands == null)
				{
					return null;
				}
				if (rpEQBands.Length != 18)
				{
					return null;
				}
				int num = 65536;
				float[] array = new float[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = 0f;
				}
				IntPtr rpResponses = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
				RuntimeUtils.EqualizerUtils.EstimateEqualizer(rpEQBands, rpResponses, ref num, 32767, 0, 0);
				float num2 = 0f;
				for (int j = 0; j < num; j++)
				{
					if (array[j] > num2)
					{
						num2 = array[j];
					}
				}
				if ((double)num2 <= 1E-08)
				{
					for (int k = 0; k < num; k++)
					{
						array[k] = 0f;
					}
				}
				else
				{
					float num3 = 1f / num2;
					for (int l = 0; l < num; l++)
					{
						array[l] *= num3;
						if (array[l] > 1f)
						{
							array[l] = 1f;
						}
					}
				}
				float[] array2 = new float[num];
				Array.Copy(array, array2, num);
				return array2;
			}
		}

		// Token: 0x0200002A RID: 42
		public class ImpulseResponseUtils
		{
			// Token: 0x06000200 RID: 512
			[DllImport("Utils.dll", CharSet = CharSet.Unicode)]
			private static extern uint GetImpulseResponseLength(string pszFilePathName, ref int piChannels);

			// Token: 0x06000201 RID: 513
			[DllImport("Utils.dll", CharSet = CharSet.Unicode)]
			private static extern int EstimateImpulseResponse(string pszFilePathName, IntPtr rpBuffer, uint nBufferSize);

			// Token: 0x06000202 RID: 514 RVA: 0x0001C070 File Offset: 0x0001A270
			public static float[] EstimateImpulseResponseSample(string szIRSPathName, out int nChannelCount)
			{
				nChannelCount = 0;
				int num = 0;
				uint impulseResponseLength = RuntimeUtils.ImpulseResponseUtils.GetImpulseResponseLength(szIRSPathName, ref num);
				if (impulseResponseLength == 0u || num == 0)
				{
					return null;
				}
				IntPtr intPtr = Marshal.AllocHGlobal((int)(impulseResponseLength * 4u));
				if (RuntimeUtils.ImpulseResponseUtils.EstimateImpulseResponse(szIRSPathName, intPtr, impulseResponseLength) == 0)
				{
					Marshal.FreeHGlobal(intPtr);
					return null;
				}
				nChannelCount = num;
				float[] array = new float[impulseResponseLength];
				Marshal.Copy(intPtr, array, 0, (int)impulseResponseLength);
				Marshal.FreeHGlobal(intPtr);
				return array;
			}
		}

		// Token: 0x0200002B RID: 43
		public class EffectDriver
		{
			// Token: 0x06000204 RID: 516
			[DllImport("ViPER4Windows.dll", CharSet = CharSet.Ansi)]
			private static extern uint GetDriverVersion(int nIndex);

			// Token: 0x06000205 RID: 517
			[DllImport("ViPER4Windows.dll", CharSet = CharSet.Ansi)]
			private static extern IntPtr GetDriverCodeName();

			// Token: 0x06000206 RID: 518 RVA: 0x0001C0D6 File Offset: 0x0001A2D6
			public static uint GetDriverMainVersion()
			{
				return RuntimeUtils.EffectDriver.GetDriverVersion(0);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0001C0DE File Offset: 0x0001A2DE
			public static uint GetDriverSubVersion()
			{
				return RuntimeUtils.EffectDriver.GetDriverVersion(1);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0001C0E6 File Offset: 0x0001A2E6
			public static uint GetDriverExtVersion()
			{
				return RuntimeUtils.EffectDriver.GetDriverVersion(2);
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
			public static string GetVersion()
			{
				return string.Concat(new string[]
				{
					RuntimeUtils.EffectDriver.GetDriverMainVersion().ToString(),
					".",
					RuntimeUtils.EffectDriver.GetDriverSubVersion().ToString(),
					".",
					RuntimeUtils.EffectDriver.GetDriverExtVersion().ToString()
				});
			}

			// Token: 0x0600020A RID: 522 RVA: 0x0001C14C File Offset: 0x0001A34C
			public static string GetCodeName()
			{
				IntPtr driverCodeName = RuntimeUtils.EffectDriver.GetDriverCodeName();
				return Marshal.PtrToStringAnsi(driverCodeName);
			}
		}

		// Token: 0x0200002C RID: 44
		public class ConfigProxy
		{
			// Token: 0x0600020C RID: 524
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int CheckConfigCompatibility(string pszConfigFilePathName);

			// Token: 0x0600020D RID: 525
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern uint GetConfigVersion(string pszConfigFilePathName);

			// Token: 0x0600020E RID: 526
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern void Update_1_0_1(string pszConfigFilePathName);

			// Token: 0x0600020F RID: 527
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern IntPtr CreateProxy();

			// Token: 0x06000210 RID: 528
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern void DestoryProxy(IntPtr pInstance);

			// Token: 0x06000211 RID: 529
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int UpdateSystemParameter(IntPtr pParameter, uint uiParameterSize, IntPtr pInstance);

			// Token: 0x06000212 RID: 530
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int UpdateMusicParameter(IntPtr pParameter, uint uiParameterSize, IntPtr pInstance);

			// Token: 0x06000213 RID: 531
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int UpdateMovieParameter(IntPtr pParameter, uint uiParameterSize, IntPtr pInstance);

			// Token: 0x06000214 RID: 532
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int UpdateFreestyleParameter(IntPtr pParameter, uint uiParameterSize, IntPtr pInstance);

			// Token: 0x06000215 RID: 533
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern int MarshalSystemParameter(IntPtr pParameter, uint uiParameterSize, IntPtr pInstance);

			// Token: 0x06000216 RID: 534
			[DllImport("ConfigProxy.dll", CharSet = CharSet.Unicode)]
			private static extern void Commit(string pszConfigFilePathName, IntPtr pInstance);

			// Token: 0x06000217 RID: 535 RVA: 0x0001C16F File Offset: 0x0001A36F
			public static bool CheckConfigVersion(string szConfigPathName)
			{
				return RuntimeUtils.ConfigProxy.CheckConfigCompatibility(szConfigPathName) != 0;
			}

			// Token: 0x06000218 RID: 536 RVA: 0x0001C17C File Offset: 0x0001A37C
			public static void UpdateConfigToCurrent(string szConfigPathName)
			{
				uint configVersion = RuntimeUtils.ConfigProxy.GetConfigVersion(szConfigPathName);
				uint num = configVersion;
				if (num != 16777217u)
				{
					return;
				}
				RuntimeUtils.ConfigProxy.Update_1_0_1(szConfigPathName);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
			public ConfigProxy(string szConfigPathName)
			{
				this.szConfigFilePathName = szConfigPathName;
				Parameters.LoadDefaultParameter(ref this.paramSystem);
				Parameters.LoadDefaultParameter(ref this.paramMusic);
				Parameters.LoadDefaultParameter(ref this.paramMovie);
				Parameters.LoadDefaultParameter(ref this.paramFreestyle);
				this.ptrConfigProxy = RuntimeUtils.ConfigProxy.CreateProxy();
				this.u64UpdateSignal = 0UL;
				if (this.ptrConfigProxy != IntPtr.Zero)
				{
					this.thUpdatingThread = new Thread(new ParameterizedThreadStart(this.UpdatingThread));
					this.thUpdatingThread.IsBackground = true;
					this.bThreadFinished = false;
					this.bKillThread = false;
					this.thUpdatingThread.Start(this);
					return;
				}
				this.thUpdatingThread = null;
				this.bThreadFinished = true;
				this.bKillThread = false;
			}

			// Token: 0x0600021A RID: 538 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
			~ConfigProxy()
			{
				this.Dispose();
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0001C2EC File Offset: 0x0001A4EC
			public void Dispose()
			{
				if (this.thUpdatingThread != null)
				{
					DateTime now = DateTime.Now;
					this.bKillThread = true;
					while (!this.bThreadFinished)
					{
						if (DateTime.Now.Subtract(now).TotalMilliseconds > 200.0)
						{
							this.thUpdatingThread.Abort();
							break;
						}
						Thread.Sleep(10);
					}
				}
				this.thUpdatingThread = null;
				this.bThreadFinished = true;
				this.bKillThread = false;
				this.u64UpdateSignal = 0UL;
				if (this.ptrConfigProxy != IntPtr.Zero)
				{
					RuntimeUtils.ConfigProxy.DestoryProxy(this.ptrConfigProxy);
				}
				this.ptrConfigProxy = IntPtr.Zero;
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0001C392 File Offset: 0x0001A592
			public bool ProxyUsable()
			{
				return !(this.ptrConfigProxy == IntPtr.Zero);
			}

			// Token: 0x0600021D RID: 541 RVA: 0x0001C3AC File Offset: 0x0001A5AC
			public void UpdateParameter(RuntimeUtils.ConfigProxy._ParamOfBaseSystem sParameter)
			{
				this.mxUpdatingMutex.WaitOne();
				this.paramSystem = sParameter;
				if (this.ptrConfigProxy == IntPtr.Zero)
				{
					this.mxUpdatingMutex.ReleaseMutex();
					return;
				}
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem)));
				Marshal.StructureToPtr(this.paramSystem, intPtr, false);
				RuntimeUtils.ConfigProxy.MarshalSystemParameter(intPtr, (uint)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem)), this.ptrConfigProxy);
				Marshal.FreeHGlobal(intPtr);
				this.mxUpdatingMutex.ReleaseMutex();
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0001C440 File Offset: 0x0001A640
			public void UpdateParameter(RuntimeUtils.ConfigProxy._ParamOfMusicMode sParameter)
			{
				this.mxUpdatingMutex.WaitOne();
				this.paramMusic = sParameter;
				if (this.ptrConfigProxy == IntPtr.Zero)
				{
					this.mxUpdatingMutex.ReleaseMutex();
					return;
				}
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode)));
				Marshal.StructureToPtr(this.paramMusic, intPtr, false);
				RuntimeUtils.ConfigProxy.UpdateMusicParameter(intPtr, (uint)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode)), this.ptrConfigProxy);
				Marshal.FreeHGlobal(intPtr);
				this.mxUpdatingMutex.ReleaseMutex();
			}

			// Token: 0x0600021F RID: 543 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
			public void UpdateParameter(RuntimeUtils.ConfigProxy._ParamOfMovieMode sParameter)
			{
				this.mxUpdatingMutex.WaitOne();
				this.paramMovie = sParameter;
				if (this.ptrConfigProxy == IntPtr.Zero)
				{
					this.mxUpdatingMutex.ReleaseMutex();
					return;
				}
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode)));
				Marshal.StructureToPtr(this.paramMovie, intPtr, false);
				RuntimeUtils.ConfigProxy.UpdateMovieParameter(intPtr, (uint)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode)), this.ptrConfigProxy);
				Marshal.FreeHGlobal(intPtr);
				this.mxUpdatingMutex.ReleaseMutex();
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0001C568 File Offset: 0x0001A768
			public void UpdateParameter(RuntimeUtils.ConfigProxy._ParamOfFreestyle sParameter)
			{
				this.mxUpdatingMutex.WaitOne();
				this.paramFreestyle = sParameter;
				if (this.ptrConfigProxy == IntPtr.Zero)
				{
					this.mxUpdatingMutex.ReleaseMutex();
					return;
				}
				IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle)));
				Marshal.StructureToPtr(this.paramFreestyle, intPtr, false);
				RuntimeUtils.ConfigProxy.UpdateFreestyleParameter(intPtr, (uint)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle)), this.ptrConfigProxy);
				Marshal.FreeHGlobal(intPtr);
				this.mxUpdatingMutex.ReleaseMutex();
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0001C5FA File Offset: 0x0001A7FA
			public void SyncConfig()
			{
				this.mxUpdatingMutex.WaitOne();
				this.u64UpdateSignal += 1UL;
				this.mxUpdatingMutex.ReleaseMutex();
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0001C624 File Offset: 0x0001A824
			private void UpdatingThread(object obj)
			{
				RuntimeUtils.ConfigProxy configProxy = obj as RuntimeUtils.ConfigProxy;
				configProxy.bThreadFinished = false;
				DateTime now = DateTime.Now;
				while (!configProxy.bKillThread)
				{
					if ((int)DateTime.Now.Subtract(now).TotalMilliseconds > this.kParameterCommitTime)
					{
						this.mxUpdatingMutex.WaitOne();
						if (configProxy.ptrConfigProxy != IntPtr.Zero && configProxy.u64UpdateSignal > 0UL)
						{
							RuntimeUtils.ConfigProxy.Commit(configProxy.szConfigFilePathName, configProxy.ptrConfigProxy);
							configProxy.u64UpdateSignal = 0UL;
							now = DateTime.Now;
						}
						this.mxUpdatingMutex.ReleaseMutex();
					}
					Thread.Sleep(10);
				}
				configProxy.bThreadFinished = true;
			}

			// Token: 0x040001D3 RID: 467
			private readonly int kParameterCommitTime = 500;

			// Token: 0x040001D4 RID: 468
			private RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramSystem = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);

			// Token: 0x040001D5 RID: 469
			private RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusic = default(RuntimeUtils.ConfigProxy._ParamOfMusicMode);

			// Token: 0x040001D6 RID: 470
			private RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovie = default(RuntimeUtils.ConfigProxy._ParamOfMovieMode);

			// Token: 0x040001D7 RID: 471
			private RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle = default(RuntimeUtils.ConfigProxy._ParamOfFreestyle);

			// Token: 0x040001D8 RID: 472
			private IntPtr ptrConfigProxy = IntPtr.Zero;

			// Token: 0x040001D9 RID: 473
			private string szConfigFilePathName = "";

			// Token: 0x040001DA RID: 474
			private Thread thUpdatingThread;

			// Token: 0x040001DB RID: 475
			private Mutex mxUpdatingMutex = new Mutex();

			// Token: 0x040001DC RID: 476
			private bool bThreadFinished;

			// Token: 0x040001DD RID: 477
			private bool bKillThread;

			// Token: 0x040001DE RID: 478
			private ulong u64UpdateSignal;

			// Token: 0x0200002D RID: 45
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct _ParamOfBaseSystem_1_0_1
			{
				// Token: 0x040001DF RID: 479
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEffectEnabled;

				// Token: 0x040001E0 RID: 480
				[MarshalAs(UnmanagedType.U4)]
				public uint m_nEffectMode;

				// Token: 0x040001E1 RID: 481
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterShortLen;

				// Token: 0x040001E2 RID: 482
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterMediumLen;

				// Token: 0x040001E3 RID: 483
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterLongLen;

				// Token: 0x040001E4 RID: 484
				[MarshalAs(UnmanagedType.R4)]
				public float m_rChannelPan;
			}

			// Token: 0x0200002E RID: 46
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct _ParamOfBaseSystem
			{
				// Token: 0x040001E5 RID: 485
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEffectEnabled;

				// Token: 0x040001E6 RID: 486
				[MarshalAs(UnmanagedType.U4)]
				public uint m_nEffectMode;

				// Token: 0x040001E7 RID: 487
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterShortLen;

				// Token: 0x040001E8 RID: 488
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterMediumLen;

				// Token: 0x040001E9 RID: 489
				[MarshalAs(UnmanagedType.I4)]
				public int m_nFilterLongLen;

				// Token: 0x040001EA RID: 490
				[MarshalAs(UnmanagedType.R4)]
				public float m_rChannelPan;

				// Token: 0x040001EB RID: 491
				[MarshalAs(UnmanagedType.I4)]
				public int m_bVirtApplied;

				// Token: 0x040001EC RID: 492
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_00;

				// Token: 0x040001ED RID: 493
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_01;

				// Token: 0x040001EE RID: 494
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_02;

				// Token: 0x040001EF RID: 495
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_03;

				// Token: 0x040001F0 RID: 496
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_04;

				// Token: 0x040001F1 RID: 497
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_05;

				// Token: 0x040001F2 RID: 498
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_06;

				// Token: 0x040001F3 RID: 499
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_07;

				// Token: 0x040001F4 RID: 500
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpChannelAngle_08;

				// Token: 0x040001F5 RID: 501
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEnvRealizeEnabled;

				// Token: 0x040001F6 RID: 502
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEnvRealizePreprocess;

				// Token: 0x040001F7 RID: 503
				[MarshalAs(UnmanagedType.I4)]
				public int m_nEnvRealizePreset;

				// Token: 0x040001F8 RID: 504
				[MarshalAs(UnmanagedType.R4)]
				public float m_rEnvRealizeDrySignal;
			}

			// Token: 0x0200002F RID: 47
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct _ParamOfMusicMode
			{
				// Token: 0x040001F9 RID: 505
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPreVolume;

				// Token: 0x040001FA RID: 506
				[MarshalAs(UnmanagedType.I4)]
				public int m_bConvolverEnabled;

				// Token: 0x040001FB RID: 507
				[MarshalAs(UnmanagedType.R4)]
				public float m_rConvolverIRGain;

				// Token: 0x040001FC RID: 508
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260, ArraySubType = UnmanagedType.U2)]
				public char[] m_szConvolverIR;

				// Token: 0x040001FD RID: 509
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERBassEnabled;

				// Token: 0x040001FE RID: 510
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERBassSpkSize;

				// Token: 0x040001FF RID: 511
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERBassFactor;

				// Token: 0x04000200 RID: 512
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERClarityEnabled;

				// Token: 0x04000201 RID: 513
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERClarityMode;

				// Token: 0x04000202 RID: 514
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERClarityFactor;

				// Token: 0x04000203 RID: 515
				[MarshalAs(UnmanagedType.I4)]
				public int m_bSurroundEnabled;

				// Token: 0x04000204 RID: 516
				[MarshalAs(UnmanagedType.I4)]
				public int m_nVHERoomSize;

				// Token: 0x04000205 RID: 517
				[MarshalAs(UnmanagedType.I4)]
				public int m_bReverbEnabled;

				// Token: 0x04000206 RID: 518
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbSize;

				// Token: 0x04000207 RID: 519
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbPredelay;

				// Token: 0x04000208 RID: 520
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDamping;

				// Token: 0x04000209 RID: 521
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDensity;

				// Token: 0x0400020A RID: 522
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbBandwidth;

				// Token: 0x0400020B RID: 523
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDecay;

				// Token: 0x0400020C RID: 524
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbEarlyMix;

				// Token: 0x0400020D RID: 525
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbMix;

				// Token: 0x0400020E RID: 526
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbGain;

				// Token: 0x0400020F RID: 527
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEqualizerEnabled;

				// Token: 0x04000210 RID: 528
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpEqualizerBands;

				// Token: 0x04000211 RID: 529
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompressorEnabled;

				// Token: 0x04000212 RID: 530
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoKnee;

				// Token: 0x04000213 RID: 531
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoGain;

				// Token: 0x04000214 RID: 532
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoAttack;

				// Token: 0x04000215 RID: 533
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoRelease;

				// Token: 0x04000216 RID: 534
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompThreshold;

				// Token: 0x04000217 RID: 535
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRatio;

				// Token: 0x04000218 RID: 536
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompKneeWidth;

				// Token: 0x04000219 RID: 537
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompGain;

				// Token: 0x0400021A RID: 538
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompAttack;

				// Token: 0x0400021B RID: 539
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRelease;

				// Token: 0x0400021C RID: 540
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCureEnabled;

				// Token: 0x0400021D RID: 541
				[MarshalAs(UnmanagedType.U4)]
				public uint m_uiCureLevel;

				// Token: 0x0400021E RID: 542
				[MarshalAs(UnmanagedType.I4)]
				public int m_bTubeEnabled;

				// Token: 0x0400021F RID: 543
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPostVolume;
			}

			// Token: 0x02000030 RID: 48
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct _ParamOfMovieMode
			{
				// Token: 0x04000220 RID: 544
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPreVolume;

				// Token: 0x04000221 RID: 545
				[MarshalAs(UnmanagedType.I4)]
				public int m_bConvolverEnabled;

				// Token: 0x04000222 RID: 546
				[MarshalAs(UnmanagedType.R4)]
				public float m_rConvolverIRGain;

				// Token: 0x04000223 RID: 547
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260, ArraySubType = UnmanagedType.U2)]
				public char[] m_szConvolverIR;

				// Token: 0x04000224 RID: 548
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERBassEnabled;

				// Token: 0x04000225 RID: 549
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERBassSpkSize;

				// Token: 0x04000226 RID: 550
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERBassFactor;

				// Token: 0x04000227 RID: 551
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERClarityEnabled;

				// Token: 0x04000228 RID: 552
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERClarityFactor;

				// Token: 0x04000229 RID: 553
				[MarshalAs(UnmanagedType.I4)]
				public int m_bSurroundEnabled;

				// Token: 0x0400022A RID: 554
				[MarshalAs(UnmanagedType.R4)]
				public float m_r3DSurroundStereo;

				// Token: 0x0400022B RID: 555
				[MarshalAs(UnmanagedType.R4)]
				public float m_r3DSurroundImage;

				// Token: 0x0400022C RID: 556
				[MarshalAs(UnmanagedType.I4)]
				public int m_bReverbEnabled;

				// Token: 0x0400022D RID: 557
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbSize;

				// Token: 0x0400022E RID: 558
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbPredelay;

				// Token: 0x0400022F RID: 559
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDamping;

				// Token: 0x04000230 RID: 560
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDensity;

				// Token: 0x04000231 RID: 561
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbBandwidth;

				// Token: 0x04000232 RID: 562
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDecay;

				// Token: 0x04000233 RID: 563
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbEarlyMix;

				// Token: 0x04000234 RID: 564
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbMix;

				// Token: 0x04000235 RID: 565
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbGain;

				// Token: 0x04000236 RID: 566
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEqualizerEnabled;

				// Token: 0x04000237 RID: 567
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpEqualizerBands;

				// Token: 0x04000238 RID: 568
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompressorEnabled;

				// Token: 0x04000239 RID: 569
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoKnee;

				// Token: 0x0400023A RID: 570
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoGain;

				// Token: 0x0400023B RID: 571
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoAttack;

				// Token: 0x0400023C RID: 572
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoRelease;

				// Token: 0x0400023D RID: 573
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompThreshold;

				// Token: 0x0400023E RID: 574
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRatio;

				// Token: 0x0400023F RID: 575
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompKneeWidth;

				// Token: 0x04000240 RID: 576
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompGain;

				// Token: 0x04000241 RID: 577
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompAttack;

				// Token: 0x04000242 RID: 578
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRelease;

				// Token: 0x04000243 RID: 579
				[MarshalAs(UnmanagedType.I4)]
				public int m_bSmartVolumeEnabled;

				// Token: 0x04000244 RID: 580
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVRatio;

				// Token: 0x04000245 RID: 581
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVVolume;

				// Token: 0x04000246 RID: 582
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVMaxGain;

				// Token: 0x04000247 RID: 583
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPostVolume;
			}

			// Token: 0x02000031 RID: 49
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct _ParamOfFreestyle
			{
				// Token: 0x04000248 RID: 584
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPreVolume;

				// Token: 0x04000249 RID: 585
				[MarshalAs(UnmanagedType.I4)]
				public int m_bConvolverEnabled;

				// Token: 0x0400024A RID: 586
				[MarshalAs(UnmanagedType.R4)]
				public float m_rConvolverIRGain;

				// Token: 0x0400024B RID: 587
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260, ArraySubType = UnmanagedType.U2)]
				public char[] m_szConvolverIR;

				// Token: 0x0400024C RID: 588
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERBassEnabled;

				// Token: 0x0400024D RID: 589
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERBassMode;

				// Token: 0x0400024E RID: 590
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERBassSpkSize;

				// Token: 0x0400024F RID: 591
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERBassFactor;

				// Token: 0x04000250 RID: 592
				[MarshalAs(UnmanagedType.I4)]
				public int m_bViPERClarityEnabled;

				// Token: 0x04000251 RID: 593
				[MarshalAs(UnmanagedType.I4)]
				public int m_nViPERClarityMode;

				// Token: 0x04000252 RID: 594
				[MarshalAs(UnmanagedType.R4)]
				public float m_rViPERClarityFactor;

				// Token: 0x04000253 RID: 595
				[MarshalAs(UnmanagedType.I4)]
				public int m_b3DSurroundEnabled;

				// Token: 0x04000254 RID: 596
				[MarshalAs(UnmanagedType.I4)]
				public int m_bVHESurroundEnabled;

				// Token: 0x04000255 RID: 597
				[MarshalAs(UnmanagedType.R4)]
				public float m_r3DSurroundStereo;

				// Token: 0x04000256 RID: 598
				[MarshalAs(UnmanagedType.R4)]
				public float m_r3DSurroundImage;

				// Token: 0x04000257 RID: 599
				[MarshalAs(UnmanagedType.I4)]
				public int m_nVHERoomSize;

				// Token: 0x04000258 RID: 600
				[MarshalAs(UnmanagedType.I4)]
				public int m_bReverbEnabled;

				// Token: 0x04000259 RID: 601
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbSize;

				// Token: 0x0400025A RID: 602
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbPredelay;

				// Token: 0x0400025B RID: 603
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDamping;

				// Token: 0x0400025C RID: 604
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDensity;

				// Token: 0x0400025D RID: 605
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbBandwidth;

				// Token: 0x0400025E RID: 606
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbDecay;

				// Token: 0x0400025F RID: 607
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbEarlyMix;

				// Token: 0x04000260 RID: 608
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbMix;

				// Token: 0x04000261 RID: 609
				[MarshalAs(UnmanagedType.R4)]
				public float m_rReverbGain;

				// Token: 0x04000262 RID: 610
				[MarshalAs(UnmanagedType.I4)]
				public int m_bEqualizerEnabled;

				// Token: 0x04000263 RID: 611
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.R4)]
				public float[] m_rpEqualizerBands;

				// Token: 0x04000264 RID: 612
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompressorEnabled;

				// Token: 0x04000265 RID: 613
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoKnee;

				// Token: 0x04000266 RID: 614
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoGain;

				// Token: 0x04000267 RID: 615
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoAttack;

				// Token: 0x04000268 RID: 616
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoRelease;

				// Token: 0x04000269 RID: 617
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCompAutoMetaNoClipping;

				// Token: 0x0400026A RID: 618
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompThreshold;

				// Token: 0x0400026B RID: 619
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRatio;

				// Token: 0x0400026C RID: 620
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompKneeWidth;

				// Token: 0x0400026D RID: 621
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompGain;

				// Token: 0x0400026E RID: 622
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompAttack;

				// Token: 0x0400026F RID: 623
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompRelease;

				// Token: 0x04000270 RID: 624
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompMetaKneeMult;

				// Token: 0x04000271 RID: 625
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompMetaMaxAttack;

				// Token: 0x04000272 RID: 626
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompMetaMaxRelease;

				// Token: 0x04000273 RID: 627
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompMetaCrest;

				// Token: 0x04000274 RID: 628
				[MarshalAs(UnmanagedType.R4)]
				public float m_rCompMetaAdapt;

				// Token: 0x04000275 RID: 629
				[MarshalAs(UnmanagedType.I4)]
				public int m_bSmartVolumeEnabled;

				// Token: 0x04000276 RID: 630
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVRatio;

				// Token: 0x04000277 RID: 631
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVVolume;

				// Token: 0x04000278 RID: 632
				[MarshalAs(UnmanagedType.R4)]
				public float m_rSVMaxGain;

				// Token: 0x04000279 RID: 633
				[MarshalAs(UnmanagedType.I4)]
				public int m_bCureEnabled;

				// Token: 0x0400027A RID: 634
				[MarshalAs(UnmanagedType.U4)]
				public uint m_uiCureLevel;

				// Token: 0x0400027B RID: 635
				[MarshalAs(UnmanagedType.I4)]
				public int m_bTubeEnabled;

				// Token: 0x0400027C RID: 636
				[MarshalAs(UnmanagedType.R4)]
				public float m_rPostVolume;
			}
		}
	}
}
