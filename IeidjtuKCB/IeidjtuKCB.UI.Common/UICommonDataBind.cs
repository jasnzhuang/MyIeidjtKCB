﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
namespace IeidjtuKCB.UI.Common
{
    public static class UICommonDataBind
    {

        /// <summary>
        /// 为ComboBox绑定数据源并提供下拉提示
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="combox">ComboBox</param>
        /// <param name="list">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">隐式字段</param>
        /// <param name="displayText">下拉提示文字</param>
        public static void BindComboBox<T>(this ComboBox combox, IList<T> list, string displayMember, string valueMember, string displayText)
        {
            AddItem(list, displayMember, displayText, valueMember);
            combox.DataSource = list;
            combox.DisplayMember = displayMember;
            if (!string.IsNullOrEmpty(valueMember))
                combox.ValueMember = valueMember;
        }

        /// <summary>
        ///向要入ComboBox中加入一个提示用的项，该项的value值为0,提示项为DisplayText
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">泛型</param>
        /// <param name="displayMember">ComboxBox中的displayMember</param>
        /// <param name="displayText">用做提示的字符串</param>
        /// <param name="valueMember">ComboxBox中的valueMember</param>
        private static void AddItem<T>(IList<T> list, string displayMember, string displayText, string valueMember)
        {
            Object _obj = Activator.CreateInstance<T>();
            Type _type = _obj.GetType();

            if (!string.IsNullOrEmpty(displayMember))
            {
                PropertyInfo _displayProperty, _valueProperty;

                _displayProperty = _type.GetProperty(displayMember);
                _valueProperty = _type.GetProperty(valueMember);


                if (((_displayProperty) != null) && ((_valueProperty) != null))
                {
                    _displayProperty.SetValue(_obj, displayText, null);
                    _valueProperty.SetValue(_obj, 0, null);
                }
                else
                {

                    MessageBox.Show("displayMemer参数错误!disPlayMember='" + displayMember + "'");
                }

            }


            list.Insert(0, (T)_obj);
        }


    }
}
