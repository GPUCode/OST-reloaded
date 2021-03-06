﻿// Decompiled with JetBrains decompiler
// Type: Products.ProductQ9
// Assembly: OnlineUpdateTool, Version=6.3.7.0, Culture=neutral, PublicKeyToken=null
// MVID: EA27343A-8B18-4C76-B602-BBE3AEAD61D6
// Assembly location: C:\Program Files (x86)\OST LA\OnlineUpdateTool.exe

namespace Products
{
    internal class ProductQ9 : ProductFastboot
    {
        public override long StartUpdate(
          string sessionId,
          string imagePath,
          string deviceId,
          int option)
        {
            ++this.runCount;
            if (this.IsDownloadOption(option, ProductOptions.BACKUP_SETTINGS))
                return (long)Product.BackupSettings(sessionId, deviceId, this.GetUserOptions(option));
            return this.IsDownloadOption(option, ProductOptions.NATIVE_UPDATE_PROCESS) || this.toolParam.Option.DoEmergecyDownload ? (long)Product.EmergencyUpdateSoftware(sessionId, this.GetUserOptions(option)) : (long)Product.UpdateSoftware(sessionId, deviceId, this.GetUserOptions(option));
        }

        public override bool HasUserOption(ProductOptions option) => option == ProductOptions.NONE || option == ProductOptions.NATIVE_UPDATE_PROCESS && this.HasNativeOption && this.toolParam.Option.NativeUpdate || (option == ProductOptions.ERASE_USER_DATA && this.HasEraseUserDataOption && this.toolParam.Option.EraseUserData || option == ProductOptions.ERASE_BOX_DATA && this.HasEraseBoxDataOption && this.toolParam.Option.EraseBoxData) || (option == ProductOptions.SWITCH_CUSTOMER_SKUID && this.HasCustomerSKUIDOption && this.toolParam.Option.SwitchCustomerSKUID || option == ProductOptions.BACKUP_SETTINGS && this.HasBackupNvOption && this.toolParam.Option.Backup || (option == ProductOptions.ERASE_FRP && this.HasEraseFrpOption && this.toolParam.Option.EraseFrp || (option == ProductOptions.UFS_PROVISION && this.HasUFSProvisionOption || option == ProductOptions.UNLOCK_SCREEN_LOCK && this.toolParam.Option.UnlockScreenLock))) || option == ProductOptions.COLLECT_APR_LOG && this.toolParam.Option.CollectAprLog;
    }
}
