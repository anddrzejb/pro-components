using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace AntDesign.Pro.Layout
{
    public partial class RightContent : AntDomComponentBase
    {
        private List<AutoCompleteDataItem<string>> DefaultOptions { get; set; } = new List<AutoCompleteDataItem<string>>
        {
            new AutoCompleteDataItem<string>
            {
                Label = "umi ui",
                Value = "umi ui"
            },
            new AutoCompleteDataItem<string>
            {
                Label = "Pro Table",
                Value = "Pro Table"
            },
            new AutoCompleteDataItem<string>
            {
                Label = "Pro Layout",
                Value = "Pro Layout"
            }
        };

        [Parameter] public EventCallback<MenuItem> OnUserItemSelected { get; set; }
        [Parameter] public EventCallback<MenuItem> OnLangItemSelected { get; set; }

        private IEnumerable<AvatarMenuItem> _avatarMenuItems = new AvatarMenuItem[]
        {
            new AvatarMenuItem { Key = "center", IconType = "user", Option = "个人中心"},
            new AvatarMenuItem { Key = "setting", IconType = "setting", Option = "个人中心"},
            new AvatarMenuItem { IsDivider = true },
            new AvatarMenuItem { Key = "logout", IconType = "logout", Option = "个人中心"}
        };

        protected override void OnInitialized()
        {
            base.OnInitialized();
            SetClassMap();
        }

        protected void SetClassMap()
        {
            ClassMapper
                .Clear()
                .Add("right");
        }
    }
}