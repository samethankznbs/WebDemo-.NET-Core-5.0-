﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategoy()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List <Blog> GetBlogByID(int id) 
		{
			return _blogDal.GetAllList(x => x.BlogId == id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetAllList();

		}
	}
}
