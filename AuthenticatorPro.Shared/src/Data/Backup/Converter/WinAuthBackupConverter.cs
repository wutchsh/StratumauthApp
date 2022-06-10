// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

namespace AuthenticatorPro.Shared.Data.Backup.Converter
{
    // TODO: investigate password protected zip
    public class WinAuthBackupConverter : UriListBackupConverter
    {
        public WinAuthBackupConverter(IIconResolver iconResolver) : base(iconResolver) { }
    }
}