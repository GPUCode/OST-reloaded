﻿// Decompiled with JetBrains decompiler
// Type: MyResources.LogService.QueryCaivsDataCompletedEventArgs
// Assembly: OnlineUpdateTool, Version=6.3.7.0, Culture=neutral, PublicKeyToken=null
// MVID: EA27343A-8B18-4C76-B602-BBE3AEAD61D6
// Assembly location: C:\Program Files (x86)\OST LA\OnlineUpdateTool.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace MyResources.LogService
{
  [DesignerCategory("code")]
  [GeneratedCode("System.Web.Services", "2.0.50727.3053")]
  [DebuggerStepThrough]
  public class QueryCaivsDataCompletedEventArgs : AsyncCompletedEventArgs
  {
    private object[] results;

    internal QueryCaivsDataCompletedEventArgs(
      object[] results,
      Exception exception,
      bool cancelled,
      object userState)
      : base(exception, cancelled, userState)
    {
      this.results = results;
    }

    public ReturnEntryOfString Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return (ReturnEntryOfString) this.results[0];
      }
    }
  }
}
