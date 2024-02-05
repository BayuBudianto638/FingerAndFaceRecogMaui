using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerAndFaceRecogMaui.Services.FingerPrintService
{
    public class FingerPrintAppService
    {
        private readonly IFingerprint _fingerprint;

        public FingerPrintAppService(IFingerprint fingerprint)
        {
            _fingerprint = fingerprint;
        }

        public async Task<bool> LoginASync()
        {
            var isTrue = false;
            var isBiometricsAvailable = await _fingerprint.IsAvailableAsync();

            if (isBiometricsAvailable)
            {
                var dialogConfig = new AuthenticationRequestConfiguration
                ("Login using biometrics", "Confirm login with your biometrics")
                {
                    FallbackTitle = "Use Password",
                    AllowAlternativeAuthentication = true,
                };

                var result = await _fingerprint.AuthenticateAsync(dialogConfig);

                if (result.Authenticated)
                {
                    return isTrue;
                }
                else
                {
                    return isTrue;
                }
            }
            else
            {
                return isTrue;
            }
        }
    }
}
