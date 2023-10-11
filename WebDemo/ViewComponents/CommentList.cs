using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using WebDemo.Models;

namespace WebDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
				ID=1,
				Username="Samethan"
				},
				new UserComment {
				ID=2,
				Username="Deneme"

				}, new UserComment
				{
					ID =3,
					Username="DAŞLFJ"
				}
			};
			return View(commentvalues);

		}
	}
}
