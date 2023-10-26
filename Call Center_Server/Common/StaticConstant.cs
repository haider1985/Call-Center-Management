﻿using Call_Center_Server.Common;

using Microsoft.AspNetCore.Identity;

namespace Call_Center_Server.Common
{
    public static class StaticConstant
    {
        public const string CallStage_New = "New";
        public const string CallStage_Processing = "Processing";
        public const string CallStage_Offering = "Offering";
        public const string CallStage_Pending = "Pending";
        public const string CallStage_Approved = "Approved";
        public const string CallStage_Cancelled = "Cancelled";
        public const string CallStage_Completed = "Completed";

        public const string Role_Admin = "Admin";
        public const string Role_User = "User";
        public const string Role_Viewer = "Viewer";


        //Default Admin User Information
        public const string AdminUser_Email = "admin@ccm.com"; // same as UserName
        public const string AdminUser_Passwoard = "Admin*123";
        public const bool AdminUser_EmailConfirmed = true;

        //Email Service Information
        public const string EmailService_EmailAddress = "";
        public const string EmailService_Password = "";
        public const string EmailService_SmtpClientInfo = "smtp-mail.outlook.com";
        public const int EmailService_SmtpClientPortNumber = 587;


    }
}
