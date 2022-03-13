using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message message)
        {
            _messageDal.Add(message);
        }

        public void Delete(Message message)
        {
            _messageDal.Delete(message);
        }

        public List<Message> GetAll(string mail)
        {
            return _messageDal.GetAll(m => m.ReceiverMail == mail);
        }

        public List<Message> GetAllInbox(string mail)
        {
            return _messageDal.GetAll(m=>m.ReceiverMail== mail);
        }

        public List<Message> GetAllSendbox(string mail)
        {
            return _messageDal.GetAll(m => m.SenderMail == mail);
        }

        public List<Message> GetAllUnreadMessage()
        {
            return _messageDal.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(m => m.MessageId == id);
        }

        public void Update(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
