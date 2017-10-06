﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace SklepSportowy.Infrastructure
{
    public class SessionMeneger : ISessionMeneger
    {
        private HttpSessionState session;
        public SessionMeneger()
        {
            session = HttpContext.Current.Session;
        }
     

        public T Get<T>(string key)
        {
            return (T)session[key];
        }

        public void Set<T>(string name, T value)
        {
            session[name] = value;
        }
        public void Abandon()
        {
            session.Abandon();
        }
        public T TryGet<T>(string key)
        {
            try
            {
                return (T)session[key];
            }
            catch (NullReferenceException)
            {
                return default(T);
            }
        }
    }
}