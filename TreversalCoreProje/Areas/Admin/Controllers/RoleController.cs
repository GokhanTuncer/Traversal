﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TreversalCoreProje.Areas.Admin.Models;

namespace TreversalCoreProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Role")]
	public class RoleController : Controller
	{

		private readonly RoleManager<AppRole> _roleManager;

		public RoleController(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}
		[Route("Index")]
		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}

		[HttpGet]
		[Route("CreateRole")]
		public IActionResult CreateRole()
		{

			return View();
		}

		[HttpPost]
		[Route("CreateRole")]

		public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
		{
			AppRole role = new AppRole()
			{
				Name = createRoleViewModel.RoleName
			};

			var result = await _roleManager.CreateAsync(role);

			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}
		[Route("DeleteRole/{id}")]
		public async Task<IActionResult> DeleteRole(int id)
		{
			var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			await _roleManager.DeleteAsync(value);

			return RedirectToAction("Index");
		}

		[HttpGet]
		[Route("DeleteRole/{id}")]
		public IActionResult UpdateRole(int id)
		{
			var value= _roleManager.Roles.FirstOrDefault(x=>x.Id == id);
			UpdateRoleViewModel updateRoleViewModel = new UpdateRoleViewModel()
			{
				RoleID = value.Id,
				RoleName = value.Name
			};
			return View(updateRoleViewModel);
		}
	}
}
