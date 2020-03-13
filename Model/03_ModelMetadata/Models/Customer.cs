﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_ModelMetadata.Models
{
    public class Customer
    {
        //[HiddenInput] // Указывает, что свойство должно быть отображено как hidden input и текстовый литерал.
        [HiddenInput(DisplayValue = false)] // Указывает, что свойство должно быть отображено только как hidden input.
        public int Id { get; set; }

        [Display(Name = "Имя")] // Определение имени метки, которая находится слева от поля ввода.
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [DataType(DataType.Date)] // Инструкция для отображения значения свойства модели. Теперь выводиться дата без времени.
        public DateTime RegistrationDate { get; set; }

        public bool IsApproved { get; set; }

        [ScaffoldColumn(false)] // Исключает свойство из генерируемой HTML разметки.
        public int Foo { get; set; }

        [UIHint("MultilineText")] // Выбор шаблона отображения
        public string Description { get; set; }
    }
}