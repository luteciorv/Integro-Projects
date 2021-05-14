namespace Services
{
    interface IOnlinePaymentService
    {
        // Informações do serviço online
        float PaymentFee(float amount);

        float Interest(float amount, int months);      
    }
}
