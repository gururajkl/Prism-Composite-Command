﻿using CompositeCommandModule.ViewModels;
using CompositeCommandModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CompositeCommandModule
{
    public class CompositeCmdModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManger = containerProvider.Resolve<IRegionManager>();
            var region = regionManger.Regions["ContentRegion"];

            var tabA = containerProvider.Resolve<TabView>();
            SetTitle(tabA, "Tab A");
            region.Add(tabA);

            var tabB = containerProvider.Resolve<TabView>();
            SetTitle(tabB, "Tab B");
            region.Add(tabB);   

            var tabC = containerProvider.Resolve<TabView>();
            SetTitle(tabC, "TAB C");
            region.Add(tabC);   
        }

        private static void SetTitle(TabView tab, string title)
        {
            ((TabViewModel)tab.DataContext).Title = title;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        { }
    }
}