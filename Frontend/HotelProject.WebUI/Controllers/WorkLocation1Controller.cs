﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
	[AllowAnonymous]

	public class WorkLocation1Controller : Controller
    {
    //    private readonly IWorkLocationService _workLocationService;
    //    public WorkLocationController(IWorkLocationService workLocationService)
    //    {
    //        _workLocationService = workLocationService;
    //    }

    //    [HttpGet]
    //    public IActionResult WorkLocationList()
    //    {
    //        var values = _workLocationService.TGetList();

    //        return Ok(values);
    //    }

    //    [HttpPost]
    //    public IActionResult AddWorkLocation(WorkLocation workLocation)
    //    {
    //        _workLocationService.TInsert(workLocation);
    //        return Ok();

    //    }

    //    [HttpDelete("{id}")]
    //    public IActionResult DeleteWorkLocation(int id)
    //    {
    //        var values = _workLocationService.TGetByID(id);
    //        _workLocationService.TDelete(values);
    //        return Ok();
    //    }

    //    [HttpPut]
    //    public IActionResult UpdateWorkLocation(WorkLocation workLocation)
    //    {
    //        _workLocationService.TUpdate(workLocation);

    //        return Ok();
    //    }


    //    [HttpGet("{id}")]
    //    public IActionResult GetWorkLocation(int id)
    //    {
    //        var values = _workLocationService.TGetByID(id);
    //        return Ok(values);
    //    }
    }
}
