namespace FAQResponder.Repository
{
    public interface ITelex
    {
        TelexConfig GetTelexConfiguration();

        string ProcessMessage(FaqRequest request);
    }
}
