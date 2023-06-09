﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendProject.DAL;
using BackendProject.ViewModel;

namespace BackendProject.ViewComponents
{
     
    
    public class EventViewComponent:ViewComponent
    {
        private readonly AppDbContext? _appDbContext;
            
        public EventViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
 
        public async Task<IViewComponentResult> InvokeAsync()
        {
         EventVM eventVM = new EventVM();
         eventVM.events = _appDbContext?.events.Include(e=>e.eventDetail).Take(8).ToList();
         
            return View(await Task.FromResult(eventVM));
        }

    }
}


