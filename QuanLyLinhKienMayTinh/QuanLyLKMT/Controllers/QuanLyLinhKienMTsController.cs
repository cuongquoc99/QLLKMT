using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuanLyLKMT;

namespace QuanLyLKMT.Controllers
{
    public class QuanLyLinhKienMTsController : Controller
    {
        private QuanLyLinhKienMayTinhEntities db = new QuanLyLinhKienMayTinhEntities();

        // GET: QuanLyLinhKienMTs
        public ActionResult Index()
        {
            return View(db.QuanLyLinhKienMTs.ToList());
        }

        // GET: QuanLyLinhKienMTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyLinhKienMT quanLyLinhKienMT = db.QuanLyLinhKienMTs.Find(id);
            if (quanLyLinhKienMT == null)
            {
                return HttpNotFound();
            }
            return View(quanLyLinhKienMT);
        }

        // GET: QuanLyLinhKienMTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLyLinhKienMTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STT,LoaiLinhKien,ThuongHieu,TenLinhKien,DungLuong,KichThuoc,BusRAM,ChuanBoNho,Chipset,GiaBan,TinhTrangKho,ThoiHanBaoHanh,GhiChu")] QuanLyLinhKienMT quanLyLinhKienMT)
        {
            if (ModelState.IsValid)
            {
                db.QuanLyLinhKienMTs.Add(quanLyLinhKienMT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanLyLinhKienMT);
        }

        // GET: QuanLyLinhKienMTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyLinhKienMT quanLyLinhKienMT = db.QuanLyLinhKienMTs.Find(id);
            if (quanLyLinhKienMT == null)
            {
                return HttpNotFound();
            }
            return View(quanLyLinhKienMT);
        }

        // POST: QuanLyLinhKienMTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STT,LoaiLinhKien,ThuongHieu,TenLinhKien,DungLuong,KichThuoc,BusRAM,ChuanBoNho,Chipset,GiaBan,TinhTrangKho,ThoiHanBaoHanh,GhiChu")] QuanLyLinhKienMT quanLyLinhKienMT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanLyLinhKienMT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanLyLinhKienMT);
        }

        // GET: QuanLyLinhKienMTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyLinhKienMT quanLyLinhKienMT = db.QuanLyLinhKienMTs.Find(id);
            if (quanLyLinhKienMT == null)
            {
                return HttpNotFound();
            }
            return View(quanLyLinhKienMT);
        }

        // POST: QuanLyLinhKienMTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuanLyLinhKienMT quanLyLinhKienMT = db.QuanLyLinhKienMTs.Find(id);
            db.QuanLyLinhKienMTs.Remove(quanLyLinhKienMT);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
