using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ViPER4WindowsBin.Utils
{
	// Token: 0x02000020 RID: 32
	internal class Parameters
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00019BB8 File Offset: 0x00017DB8
		public static char[] WriteStringToArray260(string szContext)
		{
			if (szContext.Length >= 260)
			{
				return new char[260];
			}
			char[] array = szContext.ToCharArray();
			char[] array2 = new char[260];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Convert.ToChar(0);
			}
			Array.Copy(array, array2, array.Length);
			return array2;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00019C14 File Offset: 0x00017E14
		public static byte[] ParameterSerialize(object sParameter)
		{
			int num = Marshal.SizeOf(sParameter);
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(sParameter, intPtr, false);
			byte[] array = new byte[num];
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00019C50 File Offset: 0x00017E50
		public static RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1 DeserializeParamOfBaseSystem_1_0_1(byte[] baRawData)
		{
			Type typeFromHandle = typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num != baRawData.Length)
			{
				return new RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1
				{
					m_bEffectEnabled = 0,
					m_nEffectMode = 0u,
					m_nFilterShortLen = 4096,
					m_nFilterMediumLen = 0,
					m_nFilterLongLen = 0,
					m_rChannelPan = 0f
				};
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(baRawData, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1)obj;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00019CE0 File Offset: 0x00017EE0
		public static RuntimeUtils.ConfigProxy._ParamOfBaseSystem DeserializeParamOfBaseSystem(byte[] baRawData)
		{
			Type typeFromHandle = typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num != baRawData.Length)
			{
				RuntimeUtils.ConfigProxy._ParamOfBaseSystem result = default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem);
				Parameters.LoadDefaultParameter(ref result);
				return result;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(baRawData, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (RuntimeUtils.ConfigProxy._ParamOfBaseSystem)obj;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00019D3C File Offset: 0x00017F3C
		public static RuntimeUtils.ConfigProxy._ParamOfMusicMode DeserializeParamOfMusicMode(byte[] baRawData)
		{
			Type typeFromHandle = typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num != baRawData.Length)
			{
				RuntimeUtils.ConfigProxy._ParamOfMusicMode result = default(RuntimeUtils.ConfigProxy._ParamOfMusicMode);
				Parameters.LoadDefaultParameter(ref result);
				return result;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(baRawData, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (RuntimeUtils.ConfigProxy._ParamOfMusicMode)obj;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00019D98 File Offset: 0x00017F98
		public static RuntimeUtils.ConfigProxy._ParamOfMovieMode DeserializeParamOfMovieMode(byte[] baRawData)
		{
			Type typeFromHandle = typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num != baRawData.Length)
			{
				RuntimeUtils.ConfigProxy._ParamOfMovieMode result = default(RuntimeUtils.ConfigProxy._ParamOfMovieMode);
				Parameters.LoadDefaultParameter(ref result);
				return result;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(baRawData, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (RuntimeUtils.ConfigProxy._ParamOfMovieMode)obj;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00019DF4 File Offset: 0x00017FF4
		public static RuntimeUtils.ConfigProxy._ParamOfFreestyle DeserializeParamOfFreestyle(byte[] baRawData)
		{
			Type typeFromHandle = typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle);
			int num = Marshal.SizeOf(typeFromHandle);
			if (num != baRawData.Length)
			{
				RuntimeUtils.ConfigProxy._ParamOfFreestyle result = default(RuntimeUtils.ConfigProxy._ParamOfFreestyle);
				Parameters.LoadDefaultParameter(ref result);
				return result;
			}
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(baRawData, 0, intPtr, num);
			object obj = Marshal.PtrToStructure(intPtr, typeFromHandle);
			Marshal.FreeHGlobal(intPtr);
			return (RuntimeUtils.ConfigProxy._ParamOfFreestyle)obj;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00019E60 File Offset: 0x00018060
		public static void SaveLocalPreset(string szFilePathName, RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem, RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode, RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode, RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle)
		{
			byte[] array = Parameters.ParameterSerialize(paramBaseSystem);
			byte[] array2 = Parameters.ParameterSerialize(paramMusicMode);
			byte[] array3 = Parameters.ParameterSerialize(paramMovieMode);
			byte[] array4 = Parameters.ParameterSerialize(paramFreestyle);
			if (array == null || array2 == null || array3 == null || array4 == null)
			{
				return;
			}
			try
			{
				FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
				byte[] array5 = new byte[]
				{
					86,
					105,
					80,
					69,
					82,
					52,
					87,
					105,
					110,
					100,
					111,
					119,
					115,
					88
				};
				fileStream.Write(array5, 0, array5.Length);
				fileStream.WriteByte(1);
				fileStream.WriteByte(1);
				fileStream.WriteByte(1);
				fileStream.WriteByte(1);
				fileStream.Write(array, 0, array.Length);
				fileStream.Write(array2, 0, array2.Length);
				fileStream.Write(array3, 0, array3.Length);
				fileStream.Write(array4, 0, array4.Length);
				fileStream.Flush();
				fileStream.Close();
			}
			catch (Exception ex)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(GlobalMessages.ERROR);
				stringBuilder.AppendLine(GlobalMessages.TECHNICAL_INFO);
				stringBuilder.AppendLine(ex.Message);
				MessageBox.Show(stringBuilder.ToString(), GlobalMessages.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00019FA0 File Offset: 0x000181A0
		public static bool SavePreset(string szFilePathName, RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode)
		{
			byte[] array = Parameters.ParameterSerialize(paramMusicMode);
			if (array == null)
			{
				return false;
			}
			bool result;
			try
			{
				FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
				byte[] array2 = new byte[]
				{
					86,
					105,
					80,
					69,
					82,
					52,
					87,
					105,
					110,
					100,
					111,
					119,
					115,
					88
				};
				fileStream.Write(array2, 0, array2.Length);
				fileStream.WriteByte(0);
				fileStream.WriteByte(1);
				fileStream.WriteByte(0);
				fileStream.WriteByte(0);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001A048 File Offset: 0x00018248
		public static bool SavePreset(string szFilePathName, RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode)
		{
			byte[] array = Parameters.ParameterSerialize(paramMovieMode);
			if (array == null)
			{
				return false;
			}
			bool result;
			try
			{
				FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
				byte[] array2 = new byte[]
				{
					86,
					105,
					80,
					69,
					82,
					52,
					87,
					105,
					110,
					100,
					111,
					119,
					115,
					88
				};
				fileStream.Write(array2, 0, array2.Length);
				fileStream.WriteByte(0);
				fileStream.WriteByte(0);
				fileStream.WriteByte(1);
				fileStream.WriteByte(0);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001A0F0 File Offset: 0x000182F0
		public static bool SavePreset(string szFilePathName, RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle)
		{
			byte[] array = Parameters.ParameterSerialize(paramFreestyle);
			if (array == null)
			{
				return false;
			}
			bool result;
			try
			{
				FileStream fileStream = new FileStream(szFilePathName, FileMode.Create);
				byte[] array2 = new byte[]
				{
					86,
					105,
					80,
					69,
					82,
					52,
					87,
					105,
					110,
					100,
					111,
					119,
					115,
					88
				};
				fileStream.Write(array2, 0, array2.Length);
				fileStream.WriteByte(0);
				fileStream.WriteByte(0);
				fileStream.WriteByte(0);
				fileStream.WriteByte(1);
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001A198 File Offset: 0x00018398
		public static bool ReadPreset(string szFilePathName, ref RuntimeUtils.ConfigProxy._ParamOfBaseSystem paramBaseSystem, ref RuntimeUtils.ConfigProxy._ParamOfMusicMode paramMusicMode, ref RuntimeUtils.ConfigProxy._ParamOfMovieMode paramMovieMode, ref RuntimeUtils.ConfigProxy._ParamOfFreestyle paramFreestyle, out bool bPBaseSystem, out bool bPMusicMode, out bool bPMovieMode, out bool bPFreestyle)
		{
			if (szFilePathName == null)
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				return false;
			}
			if (szFilePathName.Length <= 0)
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				return false;
			}
			if (!File.Exists(szFilePathName))
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				return false;
			}
			long num = 0L;
			try
			{
				FileInfo fileInfo = new FileInfo(szFilePathName);
				num = fileInfo.Length;
			}
			catch
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				return false;
			}
			if (num <= 0L)
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				return false;
			}
			bool result;
			try
			{
				FileStream fileStream = new FileStream(szFilePathName, FileMode.Open);
				byte[] array = new byte[]
				{
					86,
					105,
					80,
					69,
					82,
					52,
					87,
					105,
					110,
					100,
					111,
					119,
					115,
					88
				};
				byte[] array2 = new byte[14];
				if (fileStream.Read(array2, 0, array2.Length) != array2.Length)
				{
					fileStream.Close();
					bPBaseSystem = false;
					bPMusicMode = false;
					bPMovieMode = false;
					bPFreestyle = false;
					result = false;
				}
				else
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (array2[i] != array[i])
						{
							fileStream.Close();
							bPBaseSystem = false;
							bPMusicMode = false;
							bPMovieMode = false;
							bPFreestyle = false;
							return false;
						}
					}
					int num2 = fileStream.ReadByte();
					int num3 = fileStream.ReadByte();
					int num4 = fileStream.ReadByte();
					int num5 = fileStream.ReadByte();
					bPBaseSystem = false;
					bPMusicMode = false;
					bPMovieMode = false;
					bPFreestyle = false;
					long num6 = 18L;
					if (num2 == 1)
					{
						num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem));
					}
					if (num3 == 1)
					{
						num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode));
					}
					if (num4 == 1)
					{
						num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode));
					}
					if (num5 == 1)
					{
						num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle));
					}
					if (num6 != num)
					{
						num6 = 18L;
						if (num2 == 1)
						{
							num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1));
						}
						if (num3 == 1)
						{
							num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMusicMode));
						}
						if (num4 == 1)
						{
							num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfMovieMode));
						}
						if (num5 == 1)
						{
							num6 += (long)Marshal.SizeOf(typeof(RuntimeUtils.ConfigProxy._ParamOfFreestyle));
						}
						if (num6 == num)
						{
							if (num2 == 1)
							{
								byte[] array3 = new byte[Marshal.SizeOf(default(RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1))];
								if (fileStream.Read(array3, 0, array3.Length) != array3.Length)
								{
									fileStream.Close();
									bPBaseSystem = false;
									bPMusicMode = false;
									bPMovieMode = false;
									bPFreestyle = false;
									return false;
								}
								RuntimeUtils.ConfigProxy._ParamOfBaseSystem_1_0_1 paramOfBaseSystem_1_0_ = Parameters.DeserializeParamOfBaseSystem_1_0_1(array3);
								Parameters.LoadDefaultParameter(ref paramBaseSystem);
								paramBaseSystem.m_bEffectEnabled = paramOfBaseSystem_1_0_.m_bEffectEnabled;
								paramBaseSystem.m_nEffectMode = paramOfBaseSystem_1_0_.m_nEffectMode;
								paramBaseSystem.m_nFilterShortLen = paramOfBaseSystem_1_0_.m_nFilterShortLen;
								paramBaseSystem.m_nFilterMediumLen = paramOfBaseSystem_1_0_.m_nFilterMediumLen;
								paramBaseSystem.m_nFilterLongLen = paramOfBaseSystem_1_0_.m_nFilterLongLen;
								paramBaseSystem.m_rChannelPan = paramOfBaseSystem_1_0_.m_rChannelPan;
								bPBaseSystem = true;
							}
							if (num3 == 1)
							{
								byte[] array4 = new byte[Marshal.SizeOf(paramMusicMode)];
								if (fileStream.Read(array4, 0, array4.Length) != array4.Length)
								{
									fileStream.Close();
									bPBaseSystem = false;
									bPMusicMode = false;
									bPMovieMode = false;
									bPFreestyle = false;
									return false;
								}
								paramMusicMode = Parameters.DeserializeParamOfMusicMode(array4);
								bPMusicMode = true;
							}
							if (num4 == 1)
							{
								byte[] array5 = new byte[Marshal.SizeOf(paramMovieMode)];
								if (fileStream.Read(array5, 0, array5.Length) != array5.Length)
								{
									fileStream.Close();
									bPBaseSystem = false;
									bPMusicMode = false;
									bPMovieMode = false;
									bPFreestyle = false;
									return false;
								}
								paramMovieMode = Parameters.DeserializeParamOfMovieMode(array5);
								bPMovieMode = true;
							}
							if (num5 == 1)
							{
								byte[] array6 = new byte[Marshal.SizeOf(paramFreestyle)];
								if (fileStream.Read(array6, 0, array6.Length) != array6.Length)
								{
									fileStream.Close();
									bPBaseSystem = false;
									bPMusicMode = false;
									bPMovieMode = false;
									bPFreestyle = false;
									return false;
								}
								paramFreestyle = Parameters.DeserializeParamOfFreestyle(array6);
								bPFreestyle = true;
							}
							fileStream.Close();
							if (bPBaseSystem && bPMusicMode && bPMovieMode && bPFreestyle)
							{
								Parameters.SaveLocalPreset(szFilePathName, paramBaseSystem, paramMusicMode, paramMovieMode, paramFreestyle);
							}
							result = true;
						}
						else
						{
							fileStream.Close();
							bPBaseSystem = false;
							bPMusicMode = false;
							bPMovieMode = false;
							bPFreestyle = false;
							result = false;
						}
					}
					else
					{
						if (num2 == 1)
						{
							byte[] array7 = new byte[Marshal.SizeOf(paramBaseSystem)];
							if (fileStream.Read(array7, 0, array7.Length) != array7.Length)
							{
								fileStream.Close();
								bPBaseSystem = false;
								bPMusicMode = false;
								bPMovieMode = false;
								bPFreestyle = false;
								return false;
							}
							paramBaseSystem = Parameters.DeserializeParamOfBaseSystem(array7);
							bPBaseSystem = true;
						}
						if (num3 == 1)
						{
							byte[] array8 = new byte[Marshal.SizeOf(paramMusicMode)];
							if (fileStream.Read(array8, 0, array8.Length) != array8.Length)
							{
								fileStream.Close();
								bPBaseSystem = false;
								bPMusicMode = false;
								bPMovieMode = false;
								bPFreestyle = false;
								return false;
							}
							paramMusicMode = Parameters.DeserializeParamOfMusicMode(array8);
							bPMusicMode = true;
						}
						if (num4 == 1)
						{
							byte[] array9 = new byte[Marshal.SizeOf(paramMovieMode)];
							if (fileStream.Read(array9, 0, array9.Length) != array9.Length)
							{
								fileStream.Close();
								bPBaseSystem = false;
								bPMusicMode = false;
								bPMovieMode = false;
								bPFreestyle = false;
								return false;
							}
							paramMovieMode = Parameters.DeserializeParamOfMovieMode(array9);
							bPMovieMode = true;
						}
						if (num5 == 1)
						{
							byte[] array10 = new byte[Marshal.SizeOf(paramFreestyle)];
							if (fileStream.Read(array10, 0, array10.Length) != array10.Length)
							{
								fileStream.Close();
								bPBaseSystem = false;
								bPMusicMode = false;
								bPMovieMode = false;
								bPFreestyle = false;
								return false;
							}
							paramFreestyle = Parameters.DeserializeParamOfFreestyle(array10);
							bPFreestyle = true;
						}
						fileStream.Close();
						result = true;
					}
				}
			}
			catch
			{
				bPBaseSystem = false;
				bPMusicMode = false;
				bPMovieMode = false;
				bPFreestyle = false;
				result = false;
			}
			return result;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001A7DC File Offset: 0x000189DC
		public static float LOG2PARAM(float x, float mn, float mx)
		{
			return (float)((Math.Log((double)x) - Math.Log((double)mn)) / (Math.Log((double)mx) - Math.Log((double)mn)));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001A7FE File Offset: 0x000189FE
		public static float LIN2PARAM(float x, float mn, float mx)
		{
			return (x - mn) / (mx - mn);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001A807 File Offset: 0x00018A07
		public static float PARAM2LOG(float x, float mn, float mx)
		{
			return (float)Math.Exp(Math.Log((double)mn) + (double)x * (Math.Log((double)mx) - Math.Log((double)mn)));
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001A829 File Offset: 0x00018A29
		public static float PARAM2LIN(float x, float mn, float mx)
		{
			return mn + x * (mx - mn);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001A834 File Offset: 0x00018A34
		public static void LoadDefaultParameter(ref RuntimeUtils.ConfigProxy._ParamOfBaseSystem sParameter)
		{
			sParameter.m_bEffectEnabled = 0;
			sParameter.m_nEffectMode = 0u;
			sParameter.m_nFilterShortLen = 4096;
			sParameter.m_nFilterMediumLen = 0;
			sParameter.m_nFilterLongLen = 0;
			sParameter.m_rChannelPan = 0f;
			sParameter.m_bVirtApplied = 0;
			sParameter.m_rpChannelAngle_00 = new float[9];
			sParameter.m_rpChannelAngle_01 = new float[9];
			sParameter.m_rpChannelAngle_02 = new float[9];
			sParameter.m_rpChannelAngle_03 = new float[9];
			sParameter.m_rpChannelAngle_04 = new float[9];
			sParameter.m_rpChannelAngle_05 = new float[9];
			sParameter.m_rpChannelAngle_06 = new float[9];
			sParameter.m_rpChannelAngle_07 = new float[9];
			sParameter.m_rpChannelAngle_08 = new float[9];
			sParameter.m_rpChannelAngle_00[0] = 0f;
			sParameter.m_rpChannelAngle_01[0] = -30f;
			sParameter.m_rpChannelAngle_01[1] = 30f;
			sParameter.m_rpChannelAngle_02[0] = -90f;
			sParameter.m_rpChannelAngle_02[1] = 90f;
			sParameter.m_rpChannelAngle_03[0] = -150f;
			sParameter.m_rpChannelAngle_03[1] = 150f;
			sParameter.m_rpChannelAngle_04[0] = -45f;
			sParameter.m_rpChannelAngle_04[1] = 45f;
			sParameter.m_rpChannelAngle_04[2] = -135f;
			sParameter.m_rpChannelAngle_04[3] = 135f;
			sParameter.m_rpChannelAngle_05[0] = -30f;
			sParameter.m_rpChannelAngle_05[1] = 30f;
			sParameter.m_rpChannelAngle_05[2] = 0f;
			sParameter.m_rpChannelAngle_05[3] = 0f;
			sParameter.m_rpChannelAngle_05[4] = -110f;
			sParameter.m_rpChannelAngle_05[5] = 110f;
			sParameter.m_rpChannelAngle_06[0] = -30f;
			sParameter.m_rpChannelAngle_06[1] = 30f;
			sParameter.m_rpChannelAngle_06[2] = 0f;
			sParameter.m_rpChannelAngle_06[3] = 0f;
			sParameter.m_rpChannelAngle_06[4] = 180f;
			sParameter.m_rpChannelAngle_06[5] = -90f;
			sParameter.m_rpChannelAngle_06[6] = 90f;
			sParameter.m_rpChannelAngle_07[0] = -30f;
			sParameter.m_rpChannelAngle_07[1] = 30f;
			sParameter.m_rpChannelAngle_07[2] = 0f;
			sParameter.m_rpChannelAngle_07[3] = 0f;
			sParameter.m_rpChannelAngle_07[4] = -150f;
			sParameter.m_rpChannelAngle_07[5] = 150f;
			sParameter.m_rpChannelAngle_07[6] = -90f;
			sParameter.m_rpChannelAngle_07[7] = 90f;
			sParameter.m_rpChannelAngle_08[0] = -30f;
			sParameter.m_rpChannelAngle_08[1] = 30f;
			sParameter.m_rpChannelAngle_08[2] = 0f;
			sParameter.m_rpChannelAngle_08[3] = 0f;
			sParameter.m_rpChannelAngle_08[4] = -150f;
			sParameter.m_rpChannelAngle_08[5] = 150f;
			sParameter.m_rpChannelAngle_08[6] = 180f;
			sParameter.m_rpChannelAngle_08[7] = -90f;
			sParameter.m_rpChannelAngle_08[8] = 90f;
			sParameter.m_bEnvRealizeEnabled = 0;
			sParameter.m_bEnvRealizePreprocess = 1;
			sParameter.m_nEnvRealizePreset = 2;
			sParameter.m_rEnvRealizeDrySignal = 1f;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001AB24 File Offset: 0x00018D24
		public static void LoadDefaultParameter(ref RuntimeUtils.ConfigProxy._ParamOfMusicMode sParameter)
		{
			sParameter.m_rPreVolume = 1f;
			sParameter.m_bConvolverEnabled = 0;
			sParameter.m_szConvolverIR = new char[260];
			for (int i = 0; i < 256; i++)
			{
				sParameter.m_szConvolverIR[i] = '\0';
			}
			sParameter.m_rConvolverIRGain = 1f;
			sParameter.m_bViPERBassEnabled = 0;
			sParameter.m_nViPERBassSpkSize = 60;
			sParameter.m_rViPERBassFactor = 0f;
			sParameter.m_bViPERClarityEnabled = 0;
			sParameter.m_nViPERClarityMode = 0;
			sParameter.m_rViPERClarityFactor = 0f;
			sParameter.m_bSurroundEnabled = 0;
			sParameter.m_nVHERoomSize = 0;
			sParameter.m_bReverbEnabled = 0;
			sParameter.m_rReverbSize = 0f;
			sParameter.m_rReverbPredelay = 0f;
			sParameter.m_rReverbDamping = 0f;
			sParameter.m_rReverbDensity = 0f;
			sParameter.m_rReverbBandwidth = 1f;
			sParameter.m_rReverbDecay = 0f;
			sParameter.m_rReverbEarlyMix = 0f;
			sParameter.m_rReverbMix = 0f;
			sParameter.m_rReverbGain = 1f;
			sParameter.m_bEqualizerEnabled = 0;
			sParameter.m_rpEqualizerBands = new float[18];
			for (int j = 0; j < 18; j++)
			{
				sParameter.m_rpEqualizerBands[j] = 1f;
			}
			sParameter.m_bCompressorEnabled = 0;
			sParameter.m_bCompAutoKnee = 1;
			sParameter.m_bCompAutoGain = 1;
			sParameter.m_bCompAutoAttack = 1;
			sParameter.m_bCompAutoRelease = 1;
			sParameter.m_rCompThreshold = 0f;
			sParameter.m_rCompRatio = 0f;
			sParameter.m_rCompKneeWidth = 0f;
			sParameter.m_rCompGain = 0f;
			sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
			sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
			sParameter.m_bCureEnabled = 0;
			sParameter.m_uiCureLevel = 6226570u;
			sParameter.m_bTubeEnabled = 0;
			sParameter.m_rPostVolume = 1f;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		public static void LoadDefaultParameter(ref RuntimeUtils.ConfigProxy._ParamOfMovieMode sParameter)
		{
			sParameter.m_rPreVolume = 1f;
			sParameter.m_bConvolverEnabled = 0;
			sParameter.m_szConvolverIR = new char[260];
			for (int i = 0; i < 256; i++)
			{
				sParameter.m_szConvolverIR[i] = '\0';
			}
			sParameter.m_rConvolverIRGain = 1f;
			sParameter.m_bViPERBassEnabled = 0;
			sParameter.m_nViPERBassSpkSize = 60;
			sParameter.m_rViPERBassFactor = 0f;
			sParameter.m_bViPERClarityEnabled = 0;
			sParameter.m_rViPERClarityFactor = 0f;
			sParameter.m_bSurroundEnabled = 0;
			sParameter.m_r3DSurroundStereo = 1f;
			sParameter.m_r3DSurroundImage = 1f;
			sParameter.m_bReverbEnabled = 0;
			sParameter.m_rReverbSize = 0f;
			sParameter.m_rReverbPredelay = 0f;
			sParameter.m_rReverbDamping = 0f;
			sParameter.m_rReverbDensity = 0f;
			sParameter.m_rReverbBandwidth = 1f;
			sParameter.m_rReverbDecay = 0f;
			sParameter.m_rReverbEarlyMix = 0f;
			sParameter.m_rReverbMix = 0f;
			sParameter.m_rReverbGain = 1f;
			sParameter.m_bEqualizerEnabled = 0;
			sParameter.m_rpEqualizerBands = new float[18];
			for (int j = 0; j < 18; j++)
			{
				sParameter.m_rpEqualizerBands[j] = 1f;
			}
			sParameter.m_bCompressorEnabled = 0;
			sParameter.m_bCompAutoKnee = 1;
			sParameter.m_bCompAutoGain = 1;
			sParameter.m_bCompAutoAttack = 1;
			sParameter.m_bCompAutoRelease = 1;
			sParameter.m_rCompThreshold = 0f;
			sParameter.m_rCompRatio = 0f;
			sParameter.m_rCompKneeWidth = 0f;
			sParameter.m_rCompGain = 0f;
			sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
			sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
			sParameter.m_bSmartVolumeEnabled = 0;
			sParameter.m_rSVRatio = 0.5f;
			sParameter.m_rSVVolume = 1f;
			sParameter.m_rSVMaxGain = 4f;
			sParameter.m_rPostVolume = 1f;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001AEE4 File Offset: 0x000190E4
		public static void LoadDefaultParameter(ref RuntimeUtils.ConfigProxy._ParamOfFreestyle sParameter)
		{
			sParameter.m_rPreVolume = 1f;
			sParameter.m_bConvolverEnabled = 0;
			sParameter.m_szConvolverIR = new char[260];
			for (int i = 0; i < 256; i++)
			{
				sParameter.m_szConvolverIR[i] = '\0';
			}
			sParameter.m_rConvolverIRGain = 1f;
			sParameter.m_bViPERBassEnabled = 0;
			sParameter.m_nViPERBassMode = 0;
			sParameter.m_nViPERBassSpkSize = 60;
			sParameter.m_rViPERBassFactor = 0f;
			sParameter.m_bViPERClarityEnabled = 0;
			sParameter.m_nViPERClarityMode = 0;
			sParameter.m_rViPERClarityFactor = 0f;
			sParameter.m_b3DSurroundEnabled = 0;
			sParameter.m_r3DSurroundStereo = 1f;
			sParameter.m_r3DSurroundImage = 1f;
			sParameter.m_bVHESurroundEnabled = 0;
			sParameter.m_nVHERoomSize = 0;
			sParameter.m_bReverbEnabled = 0;
			sParameter.m_rReverbSize = 0f;
			sParameter.m_rReverbPredelay = 0f;
			sParameter.m_rReverbDamping = 0f;
			sParameter.m_rReverbDensity = 0f;
			sParameter.m_rReverbBandwidth = 1f;
			sParameter.m_rReverbDecay = 0f;
			sParameter.m_rReverbEarlyMix = 0f;
			sParameter.m_rReverbMix = 0f;
			sParameter.m_rReverbGain = 1f;
			sParameter.m_bEqualizerEnabled = 0;
			sParameter.m_rpEqualizerBands = new float[18];
			for (int j = 0; j < 18; j++)
			{
				sParameter.m_rpEqualizerBands[j] = 1f;
			}
			sParameter.m_bCompressorEnabled = 0;
			sParameter.m_bCompAutoKnee = 1;
			sParameter.m_bCompAutoGain = 1;
			sParameter.m_bCompAutoAttack = 1;
			sParameter.m_bCompAutoRelease = 1;
			sParameter.m_bCompAutoMetaNoClipping = 1;
			sParameter.m_rCompThreshold = 0f;
			sParameter.m_rCompRatio = 0f;
			sParameter.m_rCompKneeWidth = 0f;
			sParameter.m_rCompGain = 0f;
			sParameter.m_rCompAttack = Parameters.LOG2PARAM(0.005f, 0.0001f, 0.2f);
			sParameter.m_rCompRelease = Parameters.LOG2PARAM(0.05f, 0.005f, 2f);
			sParameter.m_rCompMetaKneeMult = Parameters.LIN2PARAM(2f, 0f, 4f);
			sParameter.m_rCompMetaMaxAttack = Parameters.LOG2PARAM(0.08f, 0.0001f, 0.2f);
			sParameter.m_rCompMetaMaxRelease = Parameters.LOG2PARAM(1f, 0.005f, 2f);
			sParameter.m_rCompMetaCrest = Parameters.LOG2PARAM(0.2f, 0.005f, 2f);
			sParameter.m_rCompMetaAdapt = Parameters.LOG2PARAM(2.5f, 1f, 4f);
			sParameter.m_bSmartVolumeEnabled = 0;
			sParameter.m_rSVRatio = 0.5f;
			sParameter.m_rSVVolume = 1f;
			sParameter.m_rSVMaxGain = 4f;
			sParameter.m_bCureEnabled = 0;
			sParameter.m_uiCureLevel = 6226570u;
			sParameter.m_bTubeEnabled = 0;
			sParameter.m_rPostVolume = 1f;
		}

		// Token: 0x040001AD RID: 429
		public const int EFFECT_MODE_MUSIC = 0;

		// Token: 0x040001AE RID: 430
		public const int EFFECT_MODE_MOVIE = 1;

		// Token: 0x040001AF RID: 431
		public const int EFFECT_MODE_FREESTYLE = 2;

		// Token: 0x040001B0 RID: 432
		public const uint CF_DEFAULT_CLEVEL = 2949820u;

		// Token: 0x040001B1 RID: 433
		public const uint CF_CMOY_CLEVEL = 3932860u;

		// Token: 0x040001B2 RID: 434
		public const uint CF_JMEIER_CLEVEL = 6226570u;

		// Token: 0x040001B3 RID: 435
		public const float MINKNEEMULT = 0f;

		// Token: 0x040001B4 RID: 436
		public const float MAXKNEEMULT = 4f;

		// Token: 0x040001B5 RID: 437
		public const float MINATTACKTIME = 0.0001f;

		// Token: 0x040001B6 RID: 438
		public const float MAXATTACKTIME = 0.2f;

		// Token: 0x040001B7 RID: 439
		public const float MINRELEASETIME = 0.005f;

		// Token: 0x040001B8 RID: 440
		public const float MAXRELEASETIME = 2f;

		// Token: 0x040001B9 RID: 441
		public const float MAXGAINDB = 60f;

		// Token: 0x040001BA RID: 442
		public const float MINADAPTTIME = 1f;

		// Token: 0x040001BB RID: 443
		public const float MAXADAPTTIME = 4f;

		// Token: 0x040001BC RID: 444
		public const float MINCRESTTIME = 0.005f;

		// Token: 0x040001BD RID: 445
		public const float MAXCRESTTIME = 2f;
	}
}
