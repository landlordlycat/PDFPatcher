﻿using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PDFPatcher
{
	public class ReaderOptions
	{
		[XmlAttribute("整页翻页")]
		public bool FullPageScroll { get; set; }
		[XmlAttribute("缩放状态")]
		public string Zoom { get; set; }
		[XmlAttribute("滚动方向")]
		public Functions.Editor.ContentDirection ContentDirection { get; set; }
	}
}
