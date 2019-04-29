using DataBunch.app.foundation.exceptions;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.models;
using DataBunch.app.sessions.repositories;
using DataBunch.app.user.models;
using DataBunch.app.user.repositories;

namespace DataBunch.app.sessions.services
{
    public static class Auth
    {
        private static User currentUser;
        private static Session currentSession;
        private static SessionRepository sessionRepository;
        private static UserRepository userRepository;

        public static bool init()
        {
            currentSession = getSessionRepository().getActiveSession();
            currentUser = currentSession?.User;

            return currentSession != null && currentUser != null;
        }

        public static void logIn(string userName, string password)
        {
            disableActiveSession();

            var user = getUserRepository().findByUsername(userName);
            if (!Hash.check(user.Password, password)) {
                throw new AuthException();
            }

            currentUser = user;
            currentSession = getSessionRepository().save(new Session(user.ID, "login", true));
        }

        public static void logOut()
        {
            disableActiveSession();
            currentUser = null;
        }

        public static bool isLoggedIn()
        {
            return currentUser != null;
        }

        public static User getUser()
        {
            return currentUser;
        }

        public static Session getSession()
        {
            return currentSession;
        }

        private static void disableActiveSession()
        {
            // get active session
            Session activeSession;
            if ((activeSession = getSessionRepository().getActiveSession()) == null) {
                return;
            }

            // deactivating current session
            activeSession.Active = false;
            activeSession = getSessionRepository().save(activeSession);
            currentSession = null;

            // creating logout session
            var logoutSession = new Session(activeSession) { Action = "logout", Active = false };
            getSessionRepository().save(logoutSession);
        }

        private static SessionRepository getSessionRepository()
        {
            return sessionRepository ?? (sessionRepository = new SessionRepository());
        }

        private static UserRepository getUserRepository()
        {
            return userRepository ?? (userRepository = new UserRepository());
        }
    }
}
