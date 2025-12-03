/*
Pseudocode / Plan:
- Create a DTO class `StudentRequest` used by StudentAPIController.Post and Put.
  - Properties: Name, Code, Email, Phone, Addresses (list of AddressRequest).
  - Use nullable strings to match existing model patterns.
  - Initialize Addresses to an empty list to avoid null reference checks in controller.
- Create a DTO class `AddressRequest`.
  - Properties: Street, City, State, ZipCode, AddressType.
- Place both classes in the `HIMS_Server.Models` namespace so the controller's using directive can resolve `StudentRequest`.
*/

using System.Collections.Generic;

namespace HIMS_Server.Models
{
    public class StudentRequest
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        // Initialize to avoid null checks in controllers
        public List<AddressRequest> Addresses { get; set; } = new List<AddressRequest>();
    }

    public class AddressRequest
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? AddressType { get; set; }
    }
}