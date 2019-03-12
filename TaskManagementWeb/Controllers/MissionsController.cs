﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskManagementWeb.Models;

namespace TaskManagementWeb.Controllers
{
    public class MissionsController : Controller
    {
        private readonly TaskManagementWebContext _context;

        public MissionsController(TaskManagementWebContext context)
        {
            _context = context;
        }

        // GET: Missions
        public async Task<IActionResult> Index(int? page)
        {
            var missions = from m in _context.Mission
                           select m;
            missions = missions.OrderBy(m => m.Id);

            int pageSize = 25;
            var completedCount = missions.Count();
            return View(await PaginatedList<Mission>.CreateAsync(missions.AsNoTracking(), page ?? 1, pageSize));

            //return View(await missions.ToListAsync());
            //return View(await _context.Mission.ToListAsync());
        }

        // GET: Missions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mission = await _context.Mission
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mission == null)
            {
                return NotFound();
            }

            return View(mission);
        }

        // GET: Missions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Missions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,AddTime,CompleteTime,Completed,Dotted")] Mission mission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mission);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction(nameof(Create));
            }
            return View(mission);
        }

        // GET: Missions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mission = await _context.Mission.FindAsync(id);
            if (mission == null)
            {
                return NotFound();
            }
            return View(mission);
        }

        // POST: Missions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,AddTime,CompleteTime,Completed,Dotted")] Mission mission)
        {
            if (id != mission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MissionExists(mission.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mission);
        }

        // GET: Missions/Edit/5
        public async Task<IActionResult> Select(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mission = await _context.Mission.FindAsync(id);
            if (mission == null)
            {
                return NotFound();
            }
            return View(mission);
        }

        // POST: Missions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Select(int id, [Bind("Id,Description,AddTime,CompleteTime,Completed,Dotted")] Mission mission)
        {
            if (id != mission.Id)
            {
                return NotFound();
            }


                if (ModelState.IsValid)
                {
                    try
                    {
                        if (mission.Completed)
                        {
                            _context.Update(mission);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            mission.Completed = true;
                            _context.Update(mission);
                            var ReEnteredMission = new Mission()
                            {
                                Description = mission.Description,
                                AddTime = mission.AddTime,
                                CompleteTime = mission.CompleteTime,
                                Completed = false,
                                Dotted = false
                            };
                            _context.Add(ReEnteredMission);
                            await _context.SaveChangesAsync();
                        }
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MissionExists(mission.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(mission);
            
        }

        // GET: Missions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mission = await _context.Mission
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mission == null)
            {
                return NotFound();
            }

            return View(mission);
        }

        // POST: Missions/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mission = await _context.Mission.FindAsync(id);
            _context.Mission.Remove(mission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MissionExists(int id)
        {
            return _context.Mission.Any(e => e.Id == id);
        }
    }
}
