namespace EmployeeServiceApi
{
    public static class ApplicationConfiguration
    {
        #region Public Methods

        public static void AddApplicationConfiguration(this WebApplication app, IConfiguration configuration)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseCors("CorsApi");

            app.UseRouting();

            app.UseXContentTypeOptions();

            app.UseReferrerPolicy(options => options.StrictOriginWhenCrossOrigin());

            app.UseCsp(options => options.FrameAncestors(s => s.Self()));

            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Permissions-Policy", "geolocation=(), midi=(),sync-xhr=(),accelerometer=(), gyroscope=(), magnetometer=(), camera=(), fullscreen=(self)");
                await next();
            });

            app.UseXfo(options => options.SameOrigin());

            app.UseXXssProtection(options => options.EnabledWithBlockMode());
        }

        #endregion Public Methods
    }
}
