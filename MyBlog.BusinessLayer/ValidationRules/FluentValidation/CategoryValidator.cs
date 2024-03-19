using System;
using FluentValidation;
using MyBlog.EntitiyLayer.Abstract;
using MyBlog.EntitiyLayer.Concrete;

namespace MyBlog.BusinessLayer.ValidationRules.FluentValidation
{
	public class CategoryValidator:AbstractValidator<Category>
	{
		public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).MinimumLength(3);
            RuleFor(c => c.CategoryName).MaximumLength(38);

        }
    }
}

