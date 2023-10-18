using System.Net.Mail;

namespace domain;

public static class Helpers
{
  public static bool IsValidEmail(string email)
  {
    try
    {
      new MailAddress(email);

      return true;
    }
    catch (FormatException)
    {
      return false;
    }
  }
}