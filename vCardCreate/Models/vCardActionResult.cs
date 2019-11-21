using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCardCreate.Models
{
    public class vCardActionResult : IActionResult
    {
        private readonly vCard _card;

        public vCardActionResult(vCard card)
        {
            _card = card;
        }
        public async Task ExecuteResultAsync(ActionContext context)
        {
            var fileName = _card.GetFullName() + ".vcf";
            var disposition = "attachment; filename =" + fileName;
            var response = context.HttpContext.Response;

            response.ContentType = "text/vcard";
            response.Headers.Add("Content-Disposition",disposition);

            var bytes = Encoding.UTF8.GetBytes(_card.ToString());
            await response.Body.WriteAsync(bytes,0,bytes.Length);
        }
    }
}
