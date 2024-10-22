﻿using Business.Concrete;
using Business.Validation.FluentValidation;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation.Results;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        [Authorize]
        public ActionResult Inbox(string mail)
        {
            var messageValue = messageManager.GetAllInbox(mail);
            return View(messageValue);
        }
        public ActionResult Sendbox(string mail)
        {
            var messageValue = messageManager.GetAllSendbox(mail);
            return View(messageValue);
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var messageValues = messageManager.GetById(id);
            return View(messageValues);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var messageValues = messageManager.GetById(id);
            return View(messageValues);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Message message)
        {
            ValidationResult result = messageValidator.Validate(message);
            if (result.IsValid)
            {
                message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                messageManager.Add(message);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult IsReadMessage(int id)
        {
            var result = messageManager.GetById(id);
            if (result.IsRead==false)
            {
                result.IsRead = true;
            }
            messageManager.Update(result);
            return RedirectToAction("ReadMessage");

        }
        public ActionResult ReadMessage(string mail)
        {
            var readMessage = messageManager.GetAll(mail).Where(m => m.IsRead == true).ToList();
            return View(readMessage);
        }
        public ActionResult GetAllUnreadMessage()
        {
            var unreadMessage = messageManager.GetAllUnreadMessage();
            return View(unreadMessage);
        }
    }
}