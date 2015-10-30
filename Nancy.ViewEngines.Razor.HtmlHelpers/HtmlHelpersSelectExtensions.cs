﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Nancy.Helpers;

namespace Nancy.ViewEngines.Razor.HtmlHelperExtensions
{
    public static class HtmlHelper
    {
        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), selectList);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList)
        {
            return ListBox(helper, name, null, selectList, null);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList)
        {
            return ListBox(helper, name, defaultOption, selectList, null, null);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), selectList, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return ListBox(helper, name, null, selectList, null, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), selectList, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, name, null, selectList, null, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, name, defaultOption, selectList, null, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return ListBox(helper, name, defaultOption, selectList, null, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectedValues, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, IDictionary<string, object> htmlAttributes)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Argument_Cannot_Be_Null_Or_Empty", "name");
            }
            return BuildListBox(name, defaultOption, selectList, selectedValues, null, false, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, object htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectedValues, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, object htmlAttributes)
        {
            return ListBox(helper, name, defaultOption, selectList, selectedValues, TypeHelper.ObjectToDictionary(htmlAttributes));
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object selectedValues, int size, bool allowMultiple)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), selectList, selectedValues, size, allowMultiple);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList, object selectedValues, int size, bool allowMultiple)
        {
            return ListBox(helper, name, null, selectList, selectedValues, size, allowMultiple, null);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, int size, bool allowMultiple)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectedValues, size, allowMultiple);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValues, int size, bool allowMultiple)
        {
            return ListBox(helper, name, defaultOption, selectList, selectedValues, size, allowMultiple, null);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                   object selectedValues, int size, bool allowMultiple, IDictionary<string, object> htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectedValues, size, allowMultiple, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                   object selectedValues, int size, bool allowMultiple, IDictionary<string, object> htmlAttributes)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Argument_Cannot_Be_Null_Or_Empty", "name");
            }

            return BuildListBox(name, defaultOption, selectList, selectedValues, size, allowMultiple, htmlAttributes);
        }

        public static IHtmlString ListBoxFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList,
                                   object selectedValues, int size, bool allowMultiple, object htmlAttributes)
        {
            return ListBox(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectedValues, size, allowMultiple, htmlAttributes);
        }

        public static IHtmlString ListBox<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                   object selectedValues, int size, bool allowMultiple, object htmlAttributes)
        {
            return ListBox(helper, name, defaultOption, selectList, selectedValues, size, allowMultiple, TypeHelper.ObjectToDictionary(htmlAttributes));
        }

        private static IHtmlString BuildListBox(string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                         object selectedValues, int? size, bool allowMultiple, IDictionary<string, object> htmlAttributes)
        {
            //var modelState = ModelState[name];
            //if (modelState != null)
            {
                selectedValues = selectedValues;// ?? ModelState[name].Value;
            }

            if (selectedValues != null)
            {
                IEnumerable values = (allowMultiple) ? ConvertTo(selectedValues) : new[] {selectedValues.ToString()};

                var newSelectList = new List<SelectListItem>();
                var selectedValueSet = new HashSet<string>(from object value in values
                                                                       select Convert.ToString(value, CultureInfo.CurrentCulture),
                                                                       StringComparer.OrdinalIgnoreCase);

                bool previousSelected = false;
                foreach (var item in selectList)
                {
                    bool selected = false;
                    // If the user's specified allowed multiple to be false
                    // only pick up the first item that was selected.
                    if (allowMultiple || !previousSelected)
                    {
                        selected = item.Selected || selectedValueSet.Contains(item.Value ?? item.Text);
                    }
                    previousSelected = previousSelected | selected;

                    newSelectList.Add(new SelectListItem(item) { Selected = selected });
                }
                selectList = newSelectList;
            }

            var tagBuilder = new TagBuilder("select")
            {
                InnerHtml = BuildListOptions(selectList, defaultOption)
            };

            //if (UnobtrusiveJavaScriptEnabled)
            //{
            //    // Add validation attributes
            //    var validationAttributes = _validationHelper.GetUnobtrusiveValidationAttributes(name);
            //    tagBuilder.MergeAttributes(validationAttributes, replaceExisting: false);
            //}

            tagBuilder.GenerateId(name);
            tagBuilder.MergeAttributes(htmlAttributes);

            tagBuilder.MergeAttribute("name", name, true);
            if (size.HasValue)
            {
                tagBuilder.MergeAttribute("size", size.ToString(), true);
            }
            if (allowMultiple)
            {
                tagBuilder.MergeAttribute("multiple", "multiple");
            }
            else if (tagBuilder.Attributes.ContainsKey("multiple"))
            {
                tagBuilder.Attributes.Remove("multiple");
            }

            // If there are any errors for a named field, we add the css attribute.
            //AddErrorClass(tagBuilder, name);

            return tagBuilder.ToHtmlString(TagRenderMode.Normal);
        }

        private static string[] ConvertTo(object selectedValues)
        {
            if (selectedValues is string)
            {
                return new []{(string)selectedValues};
            }

            if (!(selectedValues is IEnumerable))
            {
                return new string[0];
            }

            return (from object item in (IEnumerable) selectedValues select item.ToString()).ToArray();
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), selectList);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList)
        {
            return DropDownList(helper, name, null, selectList, null);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return DropDownList(helper, name, null, selectList, null, htmlAttributes);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(helper, name, null, selectList, null, htmlAttributes);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList)
        {
            return DropDownList(helper, name, defaultOption, selectList, null, null);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                        IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(helper, name, defaultOption, selectList, null, htmlAttributes);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            return DropDownList(helper, name, defaultOption, selectList, null, htmlAttributes);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValue,
                                        IDictionary<string, object> htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValue,
                                        IDictionary<string, object> htmlAttributes)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Argument_Cannot_Be_Null_Or_Empty", "name");
            }
            return BuildDropDownList(name, defaultOption, selectList, selectedValue, htmlAttributes);
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValue,
                                        object htmlAttributes)
        {
            return DropDownList(helper, ExpressionHelper.GetExpressionText(expression), defaultOption, selectList, selectList, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, string defaultOption, IEnumerable<SelectListItem> selectList, object selectedValue,
                                        object htmlAttributes)
        {
            return DropDownList(helper, name, defaultOption, selectList, selectedValue, TypeHelper.ObjectToDictionary(htmlAttributes));
        }

        public static IHtmlString DropDownListFor<TModel>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, Enum>> expression)
        {
            return DropDownListFor(helper, expression, new {});
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, object htmlAttributes)
        {
            return DropDownListFor(helper, expression, TypeHelper.ObjectToDictionary(htmlAttributes));
        }

        public static IHtmlString DropDownListFor<TModel, TProperty>(this HtmlHelpers<TModel> helper, Expression<Func<TModel, TProperty>> expression, IDictionary<string, object> htmlAttributes)
        {
            var exp = expression.Compile();
            var name = ExpressionHelper.GetExpressionText(expression);

            var currentValue = exp(helper.Model) as Enum;
            var items = currentValue.ToSelectListItems(currentValue).ToList();
            return BuildDropDownList(name, null, items, null, htmlAttributes);
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, Enum options, Enum currentValue, object htmlAttributes)
        {
            return DropDownList(helper, name, options, currentValue, TypeHelper.ObjectToDictionary(htmlAttributes));
        }

        public static IHtmlString DropDownList<TModel>(this HtmlHelpers<TModel> helper, string name, Enum options, Enum currentValue, IDictionary<string, object> htmlAttributes)
        {
            var items = currentValue.ToSelectListItems(currentValue).ToList();
            return BuildDropDownList(name, null, items, null, htmlAttributes);
        }

        private static IHtmlString BuildDropDownList(string name, string defaultOption, IEnumerable<SelectListItem> selectList,
                                              object selectedValue, IDictionary<string, object> htmlAttributes)
        {
            //var modelState = ModelState[name];
            //if (modelState != null)
            {
                selectedValue = selectedValue; //?? ModelState[name].Value;
            }
            selectedValue = Convert.ToString(selectedValue);

            if (selectedValue != null)
            {
                var newSelectList = new List<SelectListItem>(from item in selectList
                                                             select new SelectListItem(item));
                var comparer = StringComparer.InvariantCultureIgnoreCase;
                var selectedItem = newSelectList.FirstOrDefault(item => item.Selected || comparer.Equals(item.Value ?? item.Text, selectedValue));
                if (selectedItem != default(SelectListItem))
                {
                    selectedItem.Selected = true;
                    selectList = newSelectList;
                }
            }

            var tagBuilder = new TagBuilder("select")
            {
                InnerHtml = BuildListOptions(selectList, defaultOption)
            };
            tagBuilder.MergeAttributes(htmlAttributes);
            tagBuilder.MergeAttribute("name", name, true);
            tagBuilder.GenerateId(name);

            //if (UnobtrusiveJavaScriptEnabled)
            //{
            //    var validationAttributes = _validationHelper.GetUnobtrusiveValidationAttributes(name);
            //    tagBuilder.MergeAttributes(validationAttributes, replaceExisting: false);
            //}

            // If there are any errors for a named field, we add the css attribute.
            //AddErrorClass(tagBuilder, name);

            return tagBuilder.ToHtmlString(TagRenderMode.Normal);
        }

        private static string BuildListOptions(IEnumerable<SelectListItem> selectList, string optionText)
        {
            StringBuilder builder = new StringBuilder().AppendLine();
            if (optionText != null)
            {
                builder.AppendLine(ListItemToOption(new SelectListItem { Text = optionText, Value = String.Empty }));
            }
            if (selectList != null)
            {
                foreach (var item in selectList)
                {
                    builder.AppendLine(ListItemToOption(item));
                }
            }
            return builder.ToString();
        }

        private static string ListItemToOption(SelectListItem item)
        {
            var builder = new TagBuilder("option")
            {
                InnerHtml = HttpUtility.HtmlEncode(item.Text)
            };
            if (item.Value != null)
            {
                builder.Attributes["value"] = item.Value;
            }
            if (item.Selected)
            {
                builder.Attributes["selected"] = "selected";
            }
            return builder.ToString(TagRenderMode.Normal);
        }
    }
}
