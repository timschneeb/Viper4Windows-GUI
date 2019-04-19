using System;
using ViPER4WindowsBin.Utils;

namespace ViPER4WindowsBin
{
	// Token: 0x0200003A RID: 58
	internal class GlobalMessages
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00020DB8 File Offset: 0x0001EFB8
		public static void LoadMessages(string szLanguageFile)
		{
			ConfigFile configFile = new ConfigFile(szLanguageFile);
			GlobalMessages.LANGUAGE_VERSION_STR = configFile.ReadConfig("$LANGUAGE_VERSION_STR");
			GlobalMessages.LANGUAGE_TRANSLATOR_STR = configFile.ReadConfig("$LANGUAGE_TRANSLATOR_STR");
			GlobalMessages.OK = configFile.ReadConfig("$OK");
			GlobalMessages.CANCEL = configFile.ReadConfig("$CANCEL");
			GlobalMessages.ENABLE = configFile.ReadConfig("$ENABLE");
			GlobalMessages.LANGUAGE_CHANGE_NOTICE = configFile.ReadConfig("$LANGUAGE_CHANGE_NOTICE");
			GlobalMessages.MENU_LANGUAGE = configFile.ReadConfig("$MENU_LANGUAGE");
			GlobalMessages.MENU_SETTING = configFile.ReadConfig("$MENU_SETTING");
			GlobalMessages.MENU_HELP = configFile.ReadConfig("$MENU_HELP");
			GlobalMessages.LATENCY_SETTING = configFile.ReadConfig("$LATENCY_SETTING");
			GlobalMessages.CURRENT_LATENCY = configFile.ReadConfig("$CURRENT_LATENCY");
			GlobalMessages.DESIRED_LATENCY = configFile.ReadConfig("$DESIRED_LATENCY");
			GlobalMessages.LOW_LATENCY_NOTE = configFile.ReadConfig("$LOW_LATENCY_NOTE");
			GlobalMessages.CHANNEL_PAN = configFile.ReadConfig("$CHANNEL_PAN");
			GlobalMessages.LEFT = configFile.ReadConfig("$LEFT");
			GlobalMessages.RIGHT = configFile.ReadConfig("$RIGHT");
			GlobalMessages.BALANCE = configFile.ReadConfig("$BALANCE");
			GlobalMessages.VIRTUALIZATION = configFile.ReadConfig("$VIRTUALIZATION");
			GlobalMessages.AUDIO_SYSTEM_CONFIG = configFile.ReadConfig("$AUDIO_SYSTEM_CONFIG");
			GlobalMessages.AUDIO_SYSTEM_MONO = configFile.ReadConfig("$AUDIO_SYSTEM_MONO");
			GlobalMessages.AUDIO_SYSTEM_STEREO = configFile.ReadConfig("$AUDIO_SYSTEM_STEREO");
			GlobalMessages.AUDIO_SYSTEM_HEADSET = configFile.ReadConfig("$AUDIO_SYSTEM_HEADSET");
			GlobalMessages.AUDIO_SYSTEM_REARSTEREO = configFile.ReadConfig("$AUDIO_SYSTEM_REARSTEREO");
			GlobalMessages.AUDIO_SYSTEM_QUAD = configFile.ReadConfig("$AUDIO_SYSTEM_QUAD");
			GlobalMessages.AUDIO_SYSTEM_X5P1 = configFile.ReadConfig("$AUDIO_SYSTEM_X5P1");
			GlobalMessages.AUDIO_SYSTEM_X6P1 = configFile.ReadConfig("$AUDIO_SYSTEM_X6P1");
			GlobalMessages.AUDIO_SYSTEM_X7P1 = configFile.ReadConfig("$AUDIO_SYSTEM_X7P1");
			GlobalMessages.AUDIO_SYSTEM_X8P1 = configFile.ReadConfig("$AUDIO_SYSTEM_X8P1");
			GlobalMessages.VIRT_APPLIED = configFile.ReadConfig("$VIRT_APPLIED");
			GlobalMessages.VIRT_PREPOST_PROCESS = configFile.ReadConfig("$VIRT_PREPOST_PROCESS");
			GlobalMessages.VIRT_RESET = configFile.ReadConfig("$VIRT_RESET");
			GlobalMessages.VIRT_SPEAKER = configFile.ReadConfig("$VIRT_SPEAKER");
			GlobalMessages.VIRT_SPEAKER_ANGLE = configFile.ReadConfig("$VIRT_SPEAKER_ANGLE");
			GlobalMessages.VIRT_SPEAKER_FRONTLEFT = configFile.ReadConfig("$VIRT_SPEAKER_FRONTLEFT");
			GlobalMessages.VIRT_SPEAKER_FRONTRIGHT = configFile.ReadConfig("$VIRT_SPEAKER_FRONTRIGHT");
			GlobalMessages.VIRT_SPEAKER_FRONTCENTER = configFile.ReadConfig("$VIRT_SPEAKER_FRONTCENTER");
			GlobalMessages.VIRT_SPEAKER_LFE = configFile.ReadConfig("$VIRT_SPEAKER_LFE");
			GlobalMessages.VIRT_SPEAKER_BACKLEFT = configFile.ReadConfig("$VIRT_SPEAKER_BACKLEFT");
			GlobalMessages.VIRT_SPEAKER_BACKRIGHT = configFile.ReadConfig("$VIRT_SPEAKER_BACKRIGHT");
			GlobalMessages.VIRT_SPEAKER_BACKCENTER = configFile.ReadConfig("$VIRT_SPEAKER_BACKCENTER");
			GlobalMessages.VIRT_SPEAKER_SIDELEFT = configFile.ReadConfig("$VIRT_SPEAKER_SIDELEFT");
			GlobalMessages.VIRT_SPEAKER_SIDERIGHT = configFile.ReadConfig("$VIRT_SPEAKER_SIDERIGHT");
			GlobalMessages.VIRT_ENVIRONMENT = configFile.ReadConfig("$VIRT_ENVIRONMENT");
			GlobalMessages.VIRT_ENVIR_SMALLROOM = configFile.ReadConfig("$VIRT_ENVIR_SMALLROOM");
			GlobalMessages.VIRT_ENVIR_BATHROOM = configFile.ReadConfig("$VIRT_ENVIR_BATHROOM");
			GlobalMessages.VIRT_ENVIR_LIVINGROOM = configFile.ReadConfig("$VIRT_ENVIR_LIVINGROOM");
			GlobalMessages.VIRT_ENVIR_STONEROOM = configFile.ReadConfig("$VIRT_ENVIR_STONEROOM");
			GlobalMessages.VIRT_ENVIR_AUDITORIUM = configFile.ReadConfig("$VIRT_ENVIR_AUDITORIUM");
			GlobalMessages.VIRT_ENVIR_CONCERTHALL = configFile.ReadConfig("$VIRT_ENVIR_CONCERTHALL");
			GlobalMessages.VIRT_ENVIR_HALLWAY = configFile.ReadConfig("$VIRT_ENVIR_HALLWAY");
			GlobalMessages.RESET_EFFECT = configFile.ReadConfig("$RESET_EFFECT");
			GlobalMessages.SETTINGS = configFile.ReadConfig("$SETTINGS");
			GlobalMessages.CLOSE_TO_TRAY = configFile.ReadConfig("$CLOSE_TO_TRAY");
			GlobalMessages.TRAY_MENU_SETTING = configFile.ReadConfig("$TRAY_MENU_SETTING");
			GlobalMessages.TRAY_MENU_PRESETNAME = configFile.ReadConfig("$TRAY_MENU_PRESETNAME");
			GlobalMessages.TRAY_MENU_PRESETMODE = configFile.ReadConfig("$TRAY_MENU_PRESETMODE");
			GlobalMessages.TRAY_MENU_PRESETFILE = configFile.ReadConfig("$TRAY_MENU_PRESETFILE");
			GlobalMessages.ADD_NEW_ITEM = configFile.ReadConfig("$ADD_NEW_ITEM");
			GlobalMessages.REMOVE_ITEM = configFile.ReadConfig("$REMOVE_ITEM");
			GlobalMessages.REMOVE_ITEM_QUESTION = configFile.ReadConfig("$REMOVE_ITEM_QUESTION");
			GlobalMessages.MENU_TIPS_NAME = configFile.ReadConfig("$MENU_TIPS_NAME");
			GlobalMessages.MENU_TIPS_MODE = configFile.ReadConfig("$MENU_TIPS_MODE");
			GlobalMessages.SELECT_PRESET_FILE = configFile.ReadConfig("$SELECT_PRESET_FILE");
			GlobalMessages.UNNAMED = configFile.ReadConfig("$UNNAMED");
			GlobalMessages.SWITCH_OFF_EFFECT = configFile.ReadConfig("$SWITCH_OFF_EFFECT");
			GlobalMessages.SWITCH_ON_EFFECT = configFile.ReadConfig("$SWITCH_ON_EFFECT");
			GlobalMessages.EXIT_APPLICTION = configFile.ReadConfig("$EXIT_APPLICTION");
			GlobalMessages.ENABLE_APO_COEXIST = configFile.ReadConfig("$ENABLE_APO_COEXIST");
			GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE1 = configFile.ReadConfig("$ENABLE_APO_COEXIST_WRN_LINE1");
			GlobalMessages.ENABLE_APO_COEXIST_WRN_LINE2 = configFile.ReadConfig("$ENABLE_APO_COEXIST_WRN_LINE2");
			GlobalMessages.ENABLE_APO_COEXIST_RESTART = configFile.ReadConfig("$ENABLE_APO_COEXIST_RESTART");
			GlobalMessages.CHECK_UPDATE = configFile.ReadConfig("$CHECK_UPDATE");
			GlobalMessages.CHECK = configFile.ReadConfig("$CHECK");
			GlobalMessages.VERSION_FROM_INTERNET = configFile.ReadConfig("$VERSION_FROM_INTERNET");
			GlobalMessages.COPY_DOWNLOAD_LINK = configFile.ReadConfig("$COPY_DOWNLOAD_LINK");
			GlobalMessages.ABOUT = configFile.ReadConfig("$ABOUT");
			GlobalMessages.CONTROL_PANEL_VERSION = configFile.ReadConfig("$CONTROL_PANEL_VERSION");
			GlobalMessages.DRIVER_VERSION = configFile.ReadConfig("$DRIVER_VERSION");
			GlobalMessages.CODE_NAME = configFile.ReadConfig("$CODE_NAME");
			GlobalMessages.LANGUAGE_VERSION = configFile.ReadConfig("$LANGUAGE_VERSION");
			GlobalMessages.LANGUAGE_TRANSLATOR = configFile.ReadConfig("$LANGUAGE_TRANSLATOR");
			GlobalMessages.COPYRIGHT = configFile.ReadConfig("$COPYRIGHT");
			GlobalMessages.SUPPORT_FORUM = configFile.ReadConfig("$SUPPORT_FORUM");
			GlobalMessages.MASTER_POWER = configFile.ReadConfig("$MASTER_POWER");
			GlobalMessages.MUSIC_MODE = configFile.ReadConfig("$MUSIC_MODE");
			GlobalMessages.MOVIE_MODE = configFile.ReadConfig("$MOVIE_MODE");
			GlobalMessages.FREESTYLE_MODE = configFile.ReadConfig("$FREESTYLE_MODE");
			GlobalMessages.PRESET = configFile.ReadConfig("$PRESET");
			GlobalMessages.LOAD_PRESET = configFile.ReadConfig("$LOAD_PRESET");
			GlobalMessages.SAVE_PRESET = configFile.ReadConfig("$SAVE_PRESET");
			GlobalMessages.ERROR = configFile.ReadConfig("$ERROR");
			GlobalMessages.INFORMATION = configFile.ReadConfig("$INFORMATION");
			GlobalMessages.CANT_LOAD_IRS = configFile.ReadConfig("$CANT_LOAD_IRS");
			GlobalMessages.DRIVER_NOT_CONFIG = configFile.ReadConfig("$DRIVER_NOT_CONFIG");
			GlobalMessages.CANT_SAVE_PRESET = configFile.ReadConfig("$CANT_SAVE_PRESET");
			GlobalMessages.CANT_LOAD_PRESET = configFile.ReadConfig("$CANT_LOAD_PRESET");
			GlobalMessages.TECHNICAL_INFO = configFile.ReadConfig("$TECHNICAL_INFO");
			GlobalMessages.PRE_VOLUME = configFile.ReadConfig("$PRE_VOLUME");
			GlobalMessages.POST_VOLUME = configFile.ReadConfig("$POST_VOLUME");
			GlobalMessages.CONVOLVER = configFile.ReadConfig("$CONVOLVER");
			GlobalMessages.CONV_IR_GAIN = configFile.ReadConfig("$CONV_IR_GAIN");
			GlobalMessages.OPEN_CONV_IRS = configFile.ReadConfig("$OPEN_CONV_IRS");
			GlobalMessages.SURROUND = configFile.ReadConfig("$SURROUND");
			GlobalMessages.THREE_D_SURROUND = configFile.ReadConfig("$THREE_D_SURROUND");
			GlobalMessages.SURROUND_3D = configFile.ReadConfig("$SURROUND_3D");
			GlobalMessages.SURROUND_IMAGE = configFile.ReadConfig("$SURROUND_IMAGE");
			GlobalMessages.VHE_SURROUND = configFile.ReadConfig("$VHE_SURROUND");
			GlobalMessages.VHE_SMALLEST_ROOM = configFile.ReadConfig("$VHE_SMALLEST_ROOM");
			GlobalMessages.VHE_SMALL_ROOM = configFile.ReadConfig("$VHE_SMALL_ROOM");
			GlobalMessages.VHE_MID_ROOM = configFile.ReadConfig("$VHE_MID_ROOM");
			GlobalMessages.VHE_LARGE_ROOM = configFile.ReadConfig("$VHE_LARGE_ROOM");
			GlobalMessages.VHE_LARGEST_ROOM = configFile.ReadConfig("$VHE_LARGEST_ROOM");
			GlobalMessages.BASS = configFile.ReadConfig("$BASS");
			GlobalMessages.BASS_SPKSIZE = configFile.ReadConfig("$BASS_SPKSIZE");
			GlobalMessages.BASS_GAIN = configFile.ReadConfig("$BASS_GAIN");
			GlobalMessages.NATURAL_BASS = configFile.ReadConfig("$NATURAL_BASS");
			GlobalMessages.PURE_BASS = configFile.ReadConfig("$PURE_BASS");
			GlobalMessages.CLARITY = configFile.ReadConfig("$CLARITY");
			GlobalMessages.NATURAL_CLARITY = configFile.ReadConfig("$NATURAL_CLARITY");
			GlobalMessages.OZONE_CLARITY = configFile.ReadConfig("$OZONE_CLARITY");
			GlobalMessages.XHIFI_CLARITY = configFile.ReadConfig("$XHIFI_CLARITY");
			GlobalMessages.CURE = configFile.ReadConfig("$CURE");
			GlobalMessages.SLIGHT_CURE = configFile.ReadConfig("$SLIGHT_CURE");
			GlobalMessages.MODERATE_CURE = configFile.ReadConfig("$MODERATE_CURE");
			GlobalMessages.EXTREME_CURE = configFile.ReadConfig("$EXTREME_CURE");
			GlobalMessages.TUBE = configFile.ReadConfig("$TUBE");
			GlobalMessages.SMART_VOLUME = configFile.ReadConfig("$SMART_VOLUME");
			GlobalMessages.SMART_VOLUME_CONTROL_STRENGTH = configFile.ReadConfig("$SMART_VOLUME_CONTROL_STRENGTH");
			GlobalMessages.SMART_VOLUME_MAXLEVEL = configFile.ReadConfig("$SMART_VOLUME_MAXLEVEL");
			GlobalMessages.SMART_VOLUME_LEVEL = configFile.ReadConfig("$SMART_VOLUME_LEVEL");
			GlobalMessages.EQUALIZER_ADJUST = configFile.ReadConfig("$EQUALIZER_ADJUST");
			GlobalMessages.COMPRESSOR_ADJUST = configFile.ReadConfig("$COMPRESSOR_ADJUST");
			GlobalMessages.REVERB = configFile.ReadConfig("$REVERB");
			GlobalMessages.REVERB_PRESET = configFile.ReadConfig("$REVERB_PRESET");
			GlobalMessages.REVERB_PRESET_LIVINGROOM = configFile.ReadConfig("$REVERB_PRESET_LIVINGROOM");
			GlobalMessages.REVERB_PRESET_BATHROOM = configFile.ReadConfig("$REVERB_PRESET_BATHROOM");
			GlobalMessages.REVERB_PRESET_BATHROOM_BATHING = configFile.ReadConfig("$REVERB_PRESET_BATHROOM_BATHING");
			GlobalMessages.REVERB_PRESET_BEDROOM = configFile.ReadConfig("$REVERB_PRESET_BEDROOM");
			GlobalMessages.REVERB_PRESET_THEATER = configFile.ReadConfig("$REVERB_PRESET_THEATER");
			GlobalMessages.REVERB_PRESET_AUDITORIUM = configFile.ReadConfig("$REVERB_PRESET_AUDITORIUM");
			GlobalMessages.REVERB_PRESET_UNDERGROUND_PLAZA = configFile.ReadConfig("$REVERB_PRESET_UNDERGROUND_PLAZA");
			GlobalMessages.REVERB_PRESET_UNDERGROUND_PARKING = configFile.ReadConfig("$REVERB_PRESET_UNDERGROUND_PARKING");
			GlobalMessages.REVERB_PRESET_SCENE_SHOW = configFile.ReadConfig("$REVERB_PRESET_SCENE_SHOW");
			GlobalMessages.REVERB_SIZE = configFile.ReadConfig("$REVERB_SIZE");
			GlobalMessages.REVERB_DAMPING = configFile.ReadConfig("$REVERB_DAMPING");
			GlobalMessages.REVERB_DENSITY = configFile.ReadConfig("$REVERB_DENSITY");
			GlobalMessages.REVERB_BANDWIDTH = configFile.ReadConfig("$REVERB_BANDWIDTH");
			GlobalMessages.REVERB_DECAY = configFile.ReadConfig("$REVERB_DECAY");
			GlobalMessages.REVERB_PREDELAY = configFile.ReadConfig("$REVERB_PREDELAY");
			GlobalMessages.REVERB_EARLYMIX = configFile.ReadConfig("$REVERB_EARLYMIX");
			GlobalMessages.REVERB_MIX = configFile.ReadConfig("$REVERB_MIX");
			GlobalMessages.EQUALIZER = configFile.ReadConfig("$EQUALIZER");
			GlobalMessages.EQUALIZER_REALTIME_ADJUST = configFile.ReadConfig("$EQUALIZER_REALTIME_ADJUST");
			GlobalMessages.EQUALIZER_PRESET = configFile.ReadConfig("$EQUALIZER_PRESET");
			GlobalMessages.EQUALIZER_PRESET_FLAT = configFile.ReadConfig("$EQUALIZER_PRESET_FLAT");
			GlobalMessages.EQUALIZER_PRESET_SUPERBASS = configFile.ReadConfig("$EQUALIZER_PRESET_SUPERBASS");
			GlobalMessages.EQUALIZER_PRESET_SOFTBASS = configFile.ReadConfig("$EQUALIZER_PRESET_SOFTBASS");
			GlobalMessages.EQUALIZER_PRESET_ROCK = configFile.ReadConfig("$EQUALIZER_PRESET_ROCK");
			GlobalMessages.EQUALIZER_PRESET_RANDB = configFile.ReadConfig("$EQUALIZER_PRESET_RANDB");
			GlobalMessages.EQUALIZER_PRESET_CLASSIC = configFile.ReadConfig("$EQUALIZER_PRESET_CLASSIC");
			GlobalMessages.EQUALIZER_PRESET_POP = configFile.ReadConfig("$EQUALIZER_PRESET_POP");
			GlobalMessages.EQUALIZER_PRESET_JAZZ = configFile.ReadConfig("$EQUALIZER_PRESET_JAZZ");
			GlobalMessages.EQUALIZER_PRESET_BLUES = configFile.ReadConfig("$EQUALIZER_PRESET_BLUES");
			GlobalMessages.EQUALIZER_PRESET_ELECTRONIC = configFile.ReadConfig("$EQUALIZER_PRESET_ELECTRONIC");
			GlobalMessages.EQUALIZER_PRESET_VOCAL = configFile.ReadConfig("$EQUALIZER_PRESET_VOCAL");
			GlobalMessages.COMPRESSOR = configFile.ReadConfig("$COMPRESSOR");
			GlobalMessages.COMPRESSOR_THRESHOLD = configFile.ReadConfig("$COMPRESSOR_THRESHOLD");
			GlobalMessages.COMPRESSOR_KNEEWIDTH = configFile.ReadConfig("$COMPRESSOR_KNEEWIDTH");
			GlobalMessages.COMPRESSOR_AUTOKNEE = configFile.ReadConfig("$COMPRESSOR_AUTOKNEE");
			GlobalMessages.COMPRESSOR_RATIO = configFile.ReadConfig("$COMPRESSOR_RATIO");
			GlobalMessages.COMPRESSOR_ATTACK = configFile.ReadConfig("$COMPRESSOR_ATTACK");
			GlobalMessages.COMPRESSOR_AUTOATTACK = configFile.ReadConfig("$COMPRESSOR_AUTOATTACK");
			GlobalMessages.COMPRESSOR_RELEASE = configFile.ReadConfig("$COMPRESSOR_RELEASE");
			GlobalMessages.COMPRESSOR_AUTORELEASE = configFile.ReadConfig("$COMPRESSOR_AUTORELEASE");
			GlobalMessages.COMPRESSOR_MAKEUPGAIN = configFile.ReadConfig("$COMPRESSOR_MAKEUPGAIN");
			GlobalMessages.COMPRESSOR_AUTOGAIN = configFile.ReadConfig("$COMPRESSOR_AUTOGAIN");
			GlobalMessages.COMPRESSOR_MISC = configFile.ReadConfig("$COMPRESSOR_MISC");
			GlobalMessages.COMPRESSOR_NOCLIP = configFile.ReadConfig("$COMPRESSOR_NOCLIP");
			GlobalMessages.COMPRESSOR_KNEEMULT = configFile.ReadConfig("$COMPRESSOR_KNEEMULT");
			GlobalMessages.COMPRESSOR_MAXATTACK = configFile.ReadConfig("$COMPRESSOR_MAXATTACK");
			GlobalMessages.COMPRESSOR_MAXRELEASE = configFile.ReadConfig("$COMPRESSOR_MAXRELEASE");
			GlobalMessages.COMPRESSOR_CRESTTIME = configFile.ReadConfig("$COMPRESSOR_CRESTTIME");
			GlobalMessages.COMPRESSOR_ADAPTTIME = configFile.ReadConfig("$COMPRESSOR_ADAPTTIME");
		}

		// Token: 0x040002F1 RID: 753
		public static string LANGUAGE_VERSION_STR = "";

		// Token: 0x040002F2 RID: 754
		public static string LANGUAGE_TRANSLATOR_STR = "";

		// Token: 0x040002F3 RID: 755
		public static string OK = "OKay";

		// Token: 0x040002F4 RID: 756
		public static string CANCEL = "Cancel";

		// Token: 0x040002F5 RID: 757
		public static string ENABLE = "Enable";

		// Token: 0x040002F6 RID: 758
		public static string LANGUAGE_CHANGE_NOTICE = "The UI language changed, you need to restart the program.";

		// Token: 0x040002F7 RID: 759
		public static string MENU_LANGUAGE = "Language";

		// Token: 0x040002F8 RID: 760
		public static string MENU_SETTING = "Setting";

		// Token: 0x040002F9 RID: 761
		public static string MENU_HELP = "Help";

		// Token: 0x040002FA RID: 762
		public static string LATENCY_SETTING = "Latency Setting";

		// Token: 0x040002FB RID: 763
		public static string CURRENT_LATENCY = "Current Latency";

		// Token: 0x040002FC RID: 764
		public static string DESIRED_LATENCY = "Desired Latency";

		// Token: 0x040002FD RID: 765
		public static string LOW_LATENCY_NOTE = "Lower latency will increase CPU load.";

		// Token: 0x040002FE RID: 766
		public static string CHANNEL_PAN = "Channel Pan";

		// Token: 0x040002FF RID: 767
		public static string LEFT = "Left";

		// Token: 0x04000300 RID: 768
		public static string RIGHT = "Right";

		// Token: 0x04000301 RID: 769
		public static string BALANCE = "Balance";

		// Token: 0x04000302 RID: 770
		public static string VIRTUALIZATION = "Virtualization";

		// Token: 0x04000303 RID: 771
		public static string AUDIO_SYSTEM_CONFIG = "Audio system config";

		// Token: 0x04000304 RID: 772
		public static string AUDIO_SYSTEM_MONO = "Mono";

		// Token: 0x04000305 RID: 773
		public static string AUDIO_SYSTEM_STEREO = "2.0 System";

		// Token: 0x04000306 RID: 774
		public static string AUDIO_SYSTEM_HEADSET = "Headset";

		// Token: 0x04000307 RID: 775
		public static string AUDIO_SYSTEM_REARSTEREO = "Rear 2.0";

		// Token: 0x04000308 RID: 776
		public static string AUDIO_SYSTEM_QUAD = "4.0 System";

		// Token: 0x04000309 RID: 777
		public static string AUDIO_SYSTEM_X5P1 = "5.1 System";

		// Token: 0x0400030A RID: 778
		public static string AUDIO_SYSTEM_X6P1 = "6.1 System";

		// Token: 0x0400030B RID: 779
		public static string AUDIO_SYSTEM_X7P1 = "7.1 System";

		// Token: 0x0400030C RID: 780
		public static string AUDIO_SYSTEM_X8P1 = "8.1 System";

		// Token: 0x0400030D RID: 781
		public static string VIRT_APPLIED = "Apply virtualization";

		// Token: 0x0400030E RID: 782
		public static string VIRT_PREPOST_PROCESS = "Pre/Post Process";

		// Token: 0x0400030F RID: 783
		public static string VIRT_RESET = "Reset config";

		// Token: 0x04000310 RID: 784
		public static string VIRT_SPEAKER = "Speaker";

		// Token: 0x04000311 RID: 785
		public static string VIRT_SPEAKER_ANGLE = "Angle";

		// Token: 0x04000312 RID: 786
		public static string VIRT_SPEAKER_FRONTLEFT = "Front Left";

		// Token: 0x04000313 RID: 787
		public static string VIRT_SPEAKER_FRONTRIGHT = "Front Right";

		// Token: 0x04000314 RID: 788
		public static string VIRT_SPEAKER_FRONTCENTER = "Front Center";

		// Token: 0x04000315 RID: 789
		public static string VIRT_SPEAKER_LFE = "LFE (Subwoofer)";

		// Token: 0x04000316 RID: 790
		public static string VIRT_SPEAKER_BACKLEFT = "Back Left";

		// Token: 0x04000317 RID: 791
		public static string VIRT_SPEAKER_BACKRIGHT = "Back Right";

		// Token: 0x04000318 RID: 792
		public static string VIRT_SPEAKER_BACKCENTER = "Back Center";

		// Token: 0x04000319 RID: 793
		public static string VIRT_SPEAKER_SIDELEFT = "Side Left";

		// Token: 0x0400031A RID: 794
		public static string VIRT_SPEAKER_SIDERIGHT = "Side Right";

		// Token: 0x0400031B RID: 795
		public static string VIRT_ENVIRONMENT = "Virtual Environment";

		// Token: 0x0400031C RID: 796
		public static string VIRT_ENVIR_SMALLROOM = "Small Room";

		// Token: 0x0400031D RID: 797
		public static string VIRT_ENVIR_BATHROOM = "Bath Room";

		// Token: 0x0400031E RID: 798
		public static string VIRT_ENVIR_LIVINGROOM = "Living Room";

		// Token: 0x0400031F RID: 799
		public static string VIRT_ENVIR_STONEROOM = "Stone Room";

		// Token: 0x04000320 RID: 800
		public static string VIRT_ENVIR_AUDITORIUM = "Auditorium";

		// Token: 0x04000321 RID: 801
		public static string VIRT_ENVIR_CONCERTHALL = "Concert Hall";

		// Token: 0x04000322 RID: 802
		public static string VIRT_ENVIR_HALLWAY = "Hallway";

		// Token: 0x04000323 RID: 803
		public static string RESET_EFFECT = "Reset Effects";

		// Token: 0x04000324 RID: 804
		public static string SETTINGS = "Settings";

		// Token: 0x04000325 RID: 805
		public static string CLOSE_TO_TRAY = "Minimize app to tray when close";

		// Token: 0x04000326 RID: 806
		public static string TRAY_MENU_SETTING = "Tray menu setting";

		// Token: 0x04000327 RID: 807
		public static string TRAY_MENU_PRESETNAME = "Name";

		// Token: 0x04000328 RID: 808
		public static string TRAY_MENU_PRESETMODE = "Mode";

		// Token: 0x04000329 RID: 809
		public static string TRAY_MENU_PRESETFILE = "Preset";

		// Token: 0x0400032A RID: 810
		public static string ADD_NEW_ITEM = "Add new item";

		// Token: 0x0400032B RID: 811
		public static string REMOVE_ITEM = "Remove item";

		// Token: 0x0400032C RID: 812
		public static string REMOVE_ITEM_QUESTION = "Do you really want to remove this item ?";

		// Token: 0x0400032D RID: 813
		public static string MENU_TIPS_NAME = "Name:";

		// Token: 0x0400032E RID: 814
		public static string MENU_TIPS_MODE = "Mode:";

		// Token: 0x0400032F RID: 815
		public static string SELECT_PRESET_FILE = "Select preset file";

		// Token: 0x04000330 RID: 816
		public static string UNNAMED = "Unnamed";

		// Token: 0x04000331 RID: 817
		public static string SWITCH_OFF_EFFECT = "Switch off effect";

		// Token: 0x04000332 RID: 818
		public static string SWITCH_ON_EFFECT = "Switch on effect";

		// Token: 0x04000333 RID: 819
		public static string EXIT_APPLICTION = "Exit";

		// Token: 0x04000334 RID: 820
		public static string ENABLE_APO_COEXIST = "Enable APO coexists";

		// Token: 0x04000335 RID: 821
		public static string ENABLE_APO_COEXIST_WRN_LINE1 = "When APO coexists enabled, you can use all audio effects at the same time.";

		// Token: 0x04000336 RID: 822
		public static string ENABLE_APO_COEXIST_WRN_LINE2 = "But maybe this is unstable, please turn off this function if you got any audio problem.";

		// Token: 0x04000337 RID: 823
		public static string ENABLE_APO_COEXIST_RESTART = "You must restart your computer before the new setting will take effect.";

		// Token: 0x04000338 RID: 824
		public static string CHECK_UPDATE = "Check for update";

		// Token: 0x04000339 RID: 825
		public static string CHECK = "Check";

		// Token: 0x0400033A RID: 826
		public static string VERSION_FROM_INTERNET = "Version from internet";

		// Token: 0x0400033B RID: 827
		public static string COPY_DOWNLOAD_LINK = "Copy download link";

		// Token: 0x0400033C RID: 828
		public static string ABOUT = "About";

		// Token: 0x0400033D RID: 829
		public static string CONTROL_PANEL_VERSION = "Control Panel Version";

		// Token: 0x0400033E RID: 830
		public static string DRIVER_VERSION = "V4W Driver Version";

		// Token: 0x0400033F RID: 831
		public static string CODE_NAME = "V4W Codename";

		// Token: 0x04000340 RID: 832
		public static string LANGUAGE_VERSION = "Language Translate Version";

		// Token: 0x04000341 RID: 833
		public static string LANGUAGE_TRANSLATOR = "Language Translator";

		// Token: 0x04000342 RID: 834
		public static string COPYRIGHT = "Copyright (C) 2013, vipercn.com. All rights reserved.";

		// Token: 0x04000343 RID: 835
		public static string SUPPORT_FORUM = "Forum http://forum.vipersaudio.com";

		// Token: 0x04000344 RID: 836
		public static string MASTER_POWER = "Power";

		// Token: 0x04000345 RID: 837
		public static string MUSIC_MODE = "Music Mode";

		// Token: 0x04000346 RID: 838
		public static string MOVIE_MODE = "Movie Mode";

		// Token: 0x04000347 RID: 839
		public static string FREESTYLE_MODE = "Freestyle";

		// Token: 0x04000348 RID: 840
		public static string PRESET = "Preset";

		// Token: 0x04000349 RID: 841
		public static string LOAD_PRESET = "Load preset";

		// Token: 0x0400034A RID: 842
		public static string SAVE_PRESET = "Save preset";

		// Token: 0x0400034B RID: 843
		public static string ERROR = "Error";

		// Token: 0x0400034C RID: 844
		public static string INFORMATION = "Information";

		// Token: 0x0400034D RID: 845
		public static string CANT_LOAD_IRS = "Can't load impulse response, maybe selected wrong file.";

		// Token: 0x0400034E RID: 846
		public static string DRIVER_NOT_CONFIG = "The driver not configured, please run \"Configure\" first.";

		// Token: 0x0400034F RID: 847
		public static string CANT_SAVE_PRESET = "Can't save effect preset.";

		// Token: 0x04000350 RID: 848
		public static string CANT_LOAD_PRESET = "Can't load effect preset.";

		// Token: 0x04000351 RID: 849
		public static string TECHNICAL_INFO = "Technical info:";

		// Token: 0x04000352 RID: 850
		public static string PRE_VOLUME = "Pre-Volume";

		// Token: 0x04000353 RID: 851
		public static string POST_VOLUME = "Post-Volume";

		// Token: 0x04000354 RID: 852
		public static string CONVOLVER = "Convolver";

		// Token: 0x04000355 RID: 853
		public static string CONV_IR_GAIN = "IRS Power";

		// Token: 0x04000356 RID: 854
		public static string OPEN_CONV_IRS = "Open Impulse Response Sample";

		// Token: 0x04000357 RID: 855
		public static string SURROUND = "Surround";

		// Token: 0x04000358 RID: 856
		public static string THREE_D_SURROUND = "3D Surround";

		// Token: 0x04000359 RID: 857
		public static string SURROUND_3D = "Space Size";

		// Token: 0x0400035A RID: 858
		public static string SURROUND_IMAGE = "Image Size";

		// Token: 0x0400035B RID: 859
		public static string VHE_SURROUND = "ViPER Headphone Engine";

		// Token: 0x0400035C RID: 860
		public static string VHE_SMALLEST_ROOM = "Smallest Room";

		// Token: 0x0400035D RID: 861
		public static string VHE_SMALL_ROOM = "Small Room";

		// Token: 0x0400035E RID: 862
		public static string VHE_MID_ROOM = "Mid Size Room";

		// Token: 0x0400035F RID: 863
		public static string VHE_LARGE_ROOM = "Large Room";

		// Token: 0x04000360 RID: 864
		public static string VHE_LARGEST_ROOM = "Largest Room";

		// Token: 0x04000361 RID: 865
		public static string BASS = "ViPER XBass";

		// Token: 0x04000362 RID: 866
		public static string BASS_SPKSIZE = "Speaker Size";

		// Token: 0x04000363 RID: 867
		public static string BASS_GAIN = "Bass Level";

		// Token: 0x04000364 RID: 868
		public static string NATURAL_BASS = "Natural Bass";

		// Token: 0x04000365 RID: 869
		public static string PURE_BASS = "Pure Bass";

		// Token: 0x04000366 RID: 870
		public static string CLARITY = "ViPER XClarity";

		// Token: 0x04000367 RID: 871
		public static string NATURAL_CLARITY = "Natural";

		// Token: 0x04000368 RID: 872
		public static string OZONE_CLARITY = "OZone+";

		// Token: 0x04000369 RID: 873
		public static string XHIFI_CLARITY = "X-HiFi";

		// Token: 0x0400036A RID: 874
		public static string CURE = "Cure Tech +";

		// Token: 0x0400036B RID: 875
		public static string SLIGHT_CURE = "Slight";

		// Token: 0x0400036C RID: 876
		public static string MODERATE_CURE = "Moderate";

		// Token: 0x0400036D RID: 877
		public static string EXTREME_CURE = "Extreme";

		// Token: 0x0400036E RID: 878
		public static string TUBE = "Tube Simulator";

		// Token: 0x0400036F RID: 879
		public static string SMART_VOLUME = "ViPER Smart Volume";

		// Token: 0x04000370 RID: 880
		public static string SMART_VOLUME_CONTROL_STRENGTH = "Control Strength";

		// Token: 0x04000371 RID: 881
		public static string SMART_VOLUME_MAXLEVEL = "Max Gain";

		// Token: 0x04000372 RID: 882
		public static string SMART_VOLUME_LEVEL = "Desired Volume";

		// Token: 0x04000373 RID: 883
		public static string EQUALIZER_ADJUST = "Equalizer";

		// Token: 0x04000374 RID: 884
		public static string COMPRESSOR_ADJUST = "Compressor";

		// Token: 0x04000375 RID: 885
		public static string REVERB = "Reverb";

		// Token: 0x04000376 RID: 886
		public static string REVERB_PRESET = "Preset";

		// Token: 0x04000377 RID: 887
		public static string REVERB_PRESET_LIVINGROOM = "Living Room";

		// Token: 0x04000378 RID: 888
		public static string REVERB_PRESET_BATHROOM = "Bath Room";

		// Token: 0x04000379 RID: 889
		public static string REVERB_PRESET_BATHROOM_BATHING = "Bath Room (Bathing)";

		// Token: 0x0400037A RID: 890
		public static string REVERB_PRESET_BEDROOM = "Bed Room";

		// Token: 0x0400037B RID: 891
		public static string REVERB_PRESET_THEATER = "Theater";

		// Token: 0x0400037C RID: 892
		public static string REVERB_PRESET_AUDITORIUM = "Auditorium";

		// Token: 0x0400037D RID: 893
		public static string REVERB_PRESET_UNDERGROUND_PLAZA = "Underground Plaza";

		// Token: 0x0400037E RID: 894
		public static string REVERB_PRESET_UNDERGROUND_PARKING = "Underground Parking";

		// Token: 0x0400037F RID: 895
		public static string REVERB_PRESET_SCENE_SHOW = "Scene Show";

		// Token: 0x04000380 RID: 896
		public static string REVERB_SIZE = "Room Size";

		// Token: 0x04000381 RID: 897
		public static string REVERB_DAMPING = "Damping";

		// Token: 0x04000382 RID: 898
		public static string REVERB_DENSITY = "Density";

		// Token: 0x04000383 RID: 899
		public static string REVERB_BANDWIDTH = "Bandwidth";

		// Token: 0x04000384 RID: 900
		public static string REVERB_DECAY = "Decay";

		// Token: 0x04000385 RID: 901
		public static string REVERB_PREDELAY = "Pre-delay";

		// Token: 0x04000386 RID: 902
		public static string REVERB_EARLYMIX = "Early Mix";

		// Token: 0x04000387 RID: 903
		public static string REVERB_MIX = "Wet Mix";

		// Token: 0x04000388 RID: 904
		public static string EQUALIZER = "Equalizer";

		// Token: 0x04000389 RID: 905
		public static string EQUALIZER_REALTIME_ADJUST = "Realtime adjusting (more CPU usage)";

		// Token: 0x0400038A RID: 906
		public static string EQUALIZER_PRESET = "Equalizer Preset";

		// Token: 0x0400038B RID: 907
		public static string EQUALIZER_PRESET_FLAT = "Flat (Reset)";

		// Token: 0x0400038C RID: 908
		public static string EQUALIZER_PRESET_SUPERBASS = "Super Bass";

		// Token: 0x0400038D RID: 909
		public static string EQUALIZER_PRESET_SOFTBASS = "Soft Bass";

		// Token: 0x0400038E RID: 910
		public static string EQUALIZER_PRESET_ROCK = "Rock Music";

		// Token: 0x0400038F RID: 911
		public static string EQUALIZER_PRESET_RANDB = "R&B Music";

		// Token: 0x04000390 RID: 912
		public static string EQUALIZER_PRESET_CLASSIC = "Classic Music";

		// Token: 0x04000391 RID: 913
		public static string EQUALIZER_PRESET_POP = "POP Music";

		// Token: 0x04000392 RID: 914
		public static string EQUALIZER_PRESET_JAZZ = "Jazz Music";

		// Token: 0x04000393 RID: 915
		public static string EQUALIZER_PRESET_BLUES = "Blues Style";

		// Token: 0x04000394 RID: 916
		public static string EQUALIZER_PRESET_ELECTRONIC = "Electronic";

		// Token: 0x04000395 RID: 917
		public static string EQUALIZER_PRESET_VOCAL = "Vocal Enhance";

		// Token: 0x04000396 RID: 918
		public static string COMPRESSOR = "Compressor";

		// Token: 0x04000397 RID: 919
		public static string COMPRESSOR_THRESHOLD = "Threshold";

		// Token: 0x04000398 RID: 920
		public static string COMPRESSOR_KNEEWIDTH = "Knee Width";

		// Token: 0x04000399 RID: 921
		public static string COMPRESSOR_AUTOKNEE = "Auto Knee Control";

		// Token: 0x0400039A RID: 922
		public static string COMPRESSOR_RATIO = "Ratio";

		// Token: 0x0400039B RID: 923
		public static string COMPRESSOR_ATTACK = "Attack Time";

		// Token: 0x0400039C RID: 924
		public static string COMPRESSOR_AUTOATTACK = "Auto Attack Control";

		// Token: 0x0400039D RID: 925
		public static string COMPRESSOR_RELEASE = "Release Time";

		// Token: 0x0400039E RID: 926
		public static string COMPRESSOR_AUTORELEASE = "Auto Release Control";

		// Token: 0x0400039F RID: 927
		public static string COMPRESSOR_MAKEUPGAIN = "Make-Up Gain";

		// Token: 0x040003A0 RID: 928
		public static string COMPRESSOR_AUTOGAIN = "Auto Gain Control";

		// Token: 0x040003A1 RID: 929
		public static string COMPRESSOR_MISC = "Misc";

		// Token: 0x040003A2 RID: 930
		public static string COMPRESSOR_NOCLIP = "Prevent Clipping";

		// Token: 0x040003A3 RID: 931
		public static string COMPRESSOR_KNEEMULT = "Knee Mult";

		// Token: 0x040003A4 RID: 932
		public static string COMPRESSOR_MAXATTACK = "Max Attack Time";

		// Token: 0x040003A5 RID: 933
		public static string COMPRESSOR_MAXRELEASE = "Max Release Time";

		// Token: 0x040003A6 RID: 934
		public static string COMPRESSOR_CRESTTIME = "Crest Time";

		// Token: 0x040003A7 RID: 935
		public static string COMPRESSOR_ADAPTTIME = "Adapt Time";
	}
}
