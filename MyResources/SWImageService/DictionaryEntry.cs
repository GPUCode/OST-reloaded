﻿// Decompiled with JetBrains decompiler
// Type: MyResources.SWImageService.DictionaryEntry
// Assembly: OnlineUpdateTool, Version=6.3.7.0, Culture=neutral, PublicKeyToken=null
// MVID: EA27343A-8B18-4C76-B602-BBE3AEAD61D6
// Assembly location: C:\Program Files (x86)\OST LA\OnlineUpdateTool.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MyResources.SWImageService
{
  [XmlType(Namespace = "http://fihtdc.com/")]
  [DesignerCategory("code")]
  [GeneratedCode("System.Xml", "2.0.50727.3654")]
  [DebuggerStepThrough]
  [Serializable]
  public class DictionaryEntry
  {
    private object keyField;
    private object valueField;

    public object Key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    public object Value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}