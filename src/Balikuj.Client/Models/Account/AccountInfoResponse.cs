/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace Balikuj.Client.Models.Account
{
    public class AccountInfoResponse
    {
        public string FullName { get; set; }

        public string Company { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        /// <summary>
        /// Country code ISO 3166-1 alpha-2
        /// </summary>
        public string Country { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        /// <summary>
        /// Time zone
        /// </summary>
        [DefaultValue("Central Europe Standard Time")]
        public string TimeZone { get; set; }


        public bool FirstLogin { get; set; } = false;

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Account settings
        /// </summary>
        public AccountInfoSettings Settings { get; set; }
    }


    public class AccountInfoSettings
    {
        public AccountInfoSettingsOrder Order { get; set; } = new AccountInfoSettingsOrder();

        public AccountInfoSettingsPackage Package { get; set; } = new AccountInfoSettingsPackage();

        public AccountInfoSettingsPicking Picking { get; set; } = new AccountInfoSettingsPicking();

        public AccountLayoutWidth? LayoutWidth { get; set; } = AccountLayoutWidth.Fixed;
    }

    public class AccountInfoSettingsOrder
    {
        public AccountLayoutType? Layout { get; set; } = AccountLayoutType.Row;

        public int? ListSize { get; set; } = 50;

        public bool? ShowItems { get; set; } = false;
    }

    public class AccountInfoSettingsPackage
    {
        public AccountLayoutType? Layout { get; set; } = AccountLayoutType.Row;

        public int? ListSize { get; set; } = 50;

        public bool? AllowDuplicatePackages { get; set; } = false;

        public bool? OnlyMaster { get; set; } = true;
    }
    
    public class AccountInfoSettingsPicking
    {
        public List<int> Statuses { get; set; }

        public int? ActionScanAll { get; set; } = 0;

        public int? ActionPickingDone { get; set; } = 0;

        public int? SwitchStatus { get; set; }

        public int? SwitchStatusPart { get; set; }

        public bool? ShowNotes { get; set; } = true;

        public string DefaultLabelPrinter { get; set; }
    }

    public enum AccountLayoutWidth
    {
        Fixed = 0, 
        Responsive = 1 
    }

    public enum AccountLayoutType
    {
        Row = 0, 
        Grid = 1 
    }
}
