using AddItemsDynamically.Data;
using AddItemsDynamically.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddItemsDynamically.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.Include(t => t.Items).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.Include(t => t.Items)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Create()
        {
            var model = new Order();
            model.Items.Add(new OrderItem());
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,IsUrgent,Items")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.Created = DateTime.Now;
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddOrderItem([Bind("Items")] List<OrderItem> Items)
        {
            var orderItemNo = new OrderItem()
            {
                OrderItemNo = Items.Count + 1,
                Id = Items.Count + 1
            };
            Items.Add(orderItemNo);

            return PartialView("OrderItems", Items);

        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
