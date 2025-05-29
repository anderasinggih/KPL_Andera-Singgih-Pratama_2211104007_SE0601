var builder = WebApplication.CreateBuilder(args);

// Tambahkan controller support
builder.Services.AddControllers();

// Swagger (OpenAPI) support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Konfigurasi Kestrel agar pakai HTTP saja (tanpa HTTPS)
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenLocalhost(5000); // HTTP di port 5000
});

var app = builder.Build();

// Swagger saat development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Jangan pakai HTTPS redirect karena kita pakai HTTP sekarang
// app.UseHttpsRedirection();

app.UseAuthorization();

// Penting: mapping controller
app.MapControllers();

app.Run();
