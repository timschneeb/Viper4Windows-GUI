using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ViPER4WindowsBin.Properties
{
	// Token: 0x02000026 RID: 38
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0001BE31 File Offset: 0x0001A031
		internal Resources()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001BE3C File Offset: 0x0001A03C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("ViPER4WindowsBin.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0001BE7B File Offset: 0x0001A07B
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0001BE82 File Offset: 0x0001A082
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0001BE8C File Offset: 0x0001A08C
		internal static Icon Icons
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Icons", Resources.resourceCulture);
				return (Icon)@object;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
		internal static Bitmap Logo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Logo", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040001D1 RID: 465
		private static ResourceManager resourceMan;

		// Token: 0x040001D2 RID: 466
		private static CultureInfo resourceCulture;
	}
}
