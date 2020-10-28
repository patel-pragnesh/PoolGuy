﻿using System;

namespace PoolGuy.Mobile.Helpers
{
    public class Notify
    {
        private static Action<Messages.RefreshMessage> ActionSheetPopupAction = null;

        public static void SubscribeActionSheetPopup(Action<Messages.RefreshMessage> method)
        {
            ActionSheetPopupAction = method;
        }

        public static void RaiseActionSheetPopup(Messages.RefreshMessage message)
        {
            ActionSheetPopupAction?.Invoke(message);
        }

        private static Action<Messages.RefreshMessage> NavigationAction = null;
        public static void SubscribeNavigationAction(Action<Messages.RefreshMessage> method)
        {
            NavigationAction = method;
        }

        public static void RaiseNavigationAction(Messages.RefreshMessage message)
        {
            NavigationAction?.Invoke(message);
        }

        private static Action<Messages.RefreshMessage> SearchCustomerAction = null;
        public static void SubscribeSearchCustomerAction(Action<Messages.RefreshMessage> method)
        {
            SearchCustomerAction = method;
        }

        public static void RaiseSearchCustomerAction(Messages.RefreshMessage message)
        {
            SearchCustomerAction?.Invoke(message);
        }
    }
}