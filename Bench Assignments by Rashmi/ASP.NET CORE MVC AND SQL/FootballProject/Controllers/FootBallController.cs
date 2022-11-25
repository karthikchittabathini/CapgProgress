using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootballProject.FootballLeagueDbContext;
using FootballProject.Models;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FootballProject.Controllers
{
    public class FootBallController : Controller
    {
        private readonly FootballDbContext _context;

        public FootBallController(FootballDbContext context)
        {
            _context = context;
        }

        // GET: FootBall
        public async Task<IActionResult> Index()
        {
              return View(await _context.FootBallLeagues.ToListAsync());
        }

        // Show list of winners
        public async Task<IActionResult> Winners()
        {
            var TotalList = await _context.FootBallLeagues.ToListAsync();
            var WinnersList = TotalList.Where(team => team.Points == 4);
            return View(WinnersList);
        }

        // GET: FootBall/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FootBallLeagues == null)
            {
                return NotFound();
            }

            var footBallLeague = await _context.FootBallLeagues
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (footBallLeague == null)
            {
                return NotFound();
            }

            return View(footBallLeague);
        }

        // GET: FootBall/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FootBall/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootBallLeague footBallLeague)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footBallLeague);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footBallLeague);
        }

        // GET: FootBall/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FootBallLeagues == null)
            {
                return NotFound();
            }

            var footBallLeague = await _context.FootBallLeagues.FindAsync(id);
            if (footBallLeague == null)
            {
                return NotFound();
            }
            return View(footBallLeague);
        }

        // POST: FootBall/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootBallLeague footBallLeague)
        {
            if (id != footBallLeague.MatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footBallLeague);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FootBallLeagueExists(footBallLeague.MatchId))
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
            return View(footBallLeague);
        }

        // GET: FootBall/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FootBallLeagues == null)
            {
                return NotFound();
            }

            var footBallLeague = await _context.FootBallLeagues
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (footBallLeague == null)
            {
                return NotFound();
            }

            return View(footBallLeague);
        }

        // POST: FootBall/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FootBallLeagues == null)
            {
                return Problem("Entity set 'FootballDbContext.FootBallLeagues'  is null.");
            }
            var footBallLeague = await _context.FootBallLeagues.FindAsync(id);
            if (footBallLeague != null)
            {
                _context.FootBallLeagues.Remove(footBallLeague);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootBallLeagueExists(int id)
        {
          return _context.FootBallLeagues.Any(e => e.MatchId == id);
        }
    }
}
