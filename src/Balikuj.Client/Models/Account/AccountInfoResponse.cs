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
        Fixed = 0, // Fixní
        Responsive = 1 // Responsive
    }

    public enum AccountLayoutType
    {
        Row = 0, // Fixní
        Grid = 1 // Responsive
    }
}
