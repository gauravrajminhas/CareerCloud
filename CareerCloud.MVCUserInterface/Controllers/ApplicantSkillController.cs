﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.MVCUserInterface.Controllers
{
    public class ApplicantSkillController : Controller
    {
        private CareerCloudContext db = new CareerCloudContext();

        // GET: ApplicantSkill
        public ActionResult Index(Guid? id)
        {
            if (id != null)
            {
                var applicantSkillPocoes = db.ApplicantSkillPocoes.Where(applicantSkill => applicantSkill.Applicant==id).Include(a => a.ApplicantProfiles);
                return View(applicantSkillPocoes.ToList());
            }
            else
            {
                var applicantSkillPocoes = db.ApplicantSkillPocoes.Include(a => a.ApplicantProfiles);
                return View(applicantSkillPocoes.ToList());
            }
            
        }

        // GET: ApplicantSkill/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantSkillPoco applicantSkillPoco = db.ApplicantSkillPocoes.Find(id);
            if (applicantSkillPoco == null)
            {
                return HttpNotFound();
            }
            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkill/Create
        public ActionResult Create()
        {
            ViewBag.Applicant = new SelectList(db.ApplicantProfilePocoes, "Id", "Currency");
            return View();
        }

        // POST: ApplicantSkill/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Applicant,Skill,SkillLevel,StartMonth,StartYear,EndMonth,EndYear")] ApplicantSkillPoco applicantSkillPoco)
        {
            if (ModelState.IsValid)
            {
                applicantSkillPoco.Id = Guid.NewGuid();
                db.ApplicantSkillPocoes.Add(applicantSkillPoco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Applicant = new SelectList(db.ApplicantProfilePocoes, "Id", "Currency", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkill/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantSkillPoco applicantSkillPoco = db.ApplicantSkillPocoes.Find(id);
            if (applicantSkillPoco == null)
            {
                return HttpNotFound();
            }
            ViewBag.Applicant = new SelectList(db.ApplicantProfilePocoes, "Id", "Currency", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // POST: ApplicantSkill/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Applicant,Skill,SkillLevel,StartMonth,StartYear,EndMonth,EndYear")] ApplicantSkillPoco applicantSkillPoco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicantSkillPoco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Applicant = new SelectList(db.ApplicantProfilePocoes, "Id", "Currency", applicantSkillPoco.Applicant);
            return View(applicantSkillPoco);
        }

        // GET: ApplicantSkill/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantSkillPoco applicantSkillPoco = db.ApplicantSkillPocoes.Find(id);
            if (applicantSkillPoco == null)
            {
                return HttpNotFound();
            }
            return View(applicantSkillPoco);
        }

        // POST: ApplicantSkill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ApplicantSkillPoco applicantSkillPoco = db.ApplicantSkillPocoes.Find(id);
            db.ApplicantSkillPocoes.Remove(applicantSkillPoco);
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
