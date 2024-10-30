namespace fsbr_desafio.Services;

public static class Formatar
{
    public static string Npu(string? npu)
    {
        if (npu is null || npu.Length != 20)
            return "";

        // Formato esperado (20 caracteres): 1234567-12.1234.1.12.1234
        var formatado = $"{npu.Substring(0, 7)}-{npu.Substring(7, 2)}.{npu.Substring(9, 4)}.{npu.Substring(13, 1)}.{npu.Substring(14, 2)}.{npu.Substring(16, 4)}";
        return formatado;
    }
    
}