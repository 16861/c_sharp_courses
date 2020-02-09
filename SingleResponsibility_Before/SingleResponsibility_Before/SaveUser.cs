namespace SingleResponsibility_Before {
    class SaveUserManager {
        public void SaveUser(User user) {
            saveUserConsoleOutput(user);
        }

         private void saveUserConsoleOutput(User user)
        {
            Logger.LogLine("Save user to DB.");
        }
    }
}