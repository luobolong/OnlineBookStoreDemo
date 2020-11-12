using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Helper
{
    public static class StringChecker
    {
        // 用户名由字母和数字组成
        public static bool IsUsername(string username) => new Regex(@"^[a-zA-Z0-9]+$").IsMatch(username);
        // 密码由6-16个字符组成，区分大小写，至少包含一个字母，一个数字和一个特殊字符
        public static bool IsPassword(string password) => new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,14}$").IsMatch(password);
        // 验证邮箱地址
        public static bool IsEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // 判断是否是年份
        public static bool IsYear(string compare) => new Regex(@"[0-9]{4}$").IsMatch(compare);
        // 判断是否是日期
        public static bool IsDate(string compare)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(compare);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // 判断是否是数字
        public static bool IsNumber(string compare) => new Regex(@"^[0-9]\d*$").IsMatch(compare);
        // 判断是否是0或1
        public static bool IsBit(string compare) => new Regex(@"^[0-1]$").IsMatch(compare);
        // 判断是否是两位小数，整数部分最多8位
        public static bool IsNumberic(string compare) => new Regex(@"^[0-9]{1,8}\.[0-9]{2}$").IsMatch(compare);
        // 判断是否是手机号
        public static bool IsPhoneNumber(string compare) => new Regex(@"^1[3456789]\d{9}$").IsMatch(compare);
    }
}
