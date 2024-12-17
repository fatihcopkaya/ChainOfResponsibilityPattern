# **Chain of Responsibility Pattern - Payment Workflow**

This project demonstrates the **Chain of Responsibility** design pattern to manage a payment workflow. Each step of the process is handled by a separate class, and the flow is executed sequentially.

---

## **Project Purpose**

The purpose of this project is to process multiple control steps (e.g., dealer check, commission check) in a flexible and extensible chain structure.

---

## **Class Responsibilities**

### **Abstracts**

- **`IHandler`**  
  Defines the contract for all handlers.  
  - `Handle`: Processes the current step.  
  - `SetNext`: Sets the next handler in the chain.

- **`BaseHandler`**  
  Implements common chain logic, such as transitioning to the next handler.  
  - `NextChain`: Passes control to the next handler.

- **`ITransportObject`**  
  Represents the base structure of the transport object, containing essential data:  
  - `Amount`  
  - `OrderId`  

---

### **Handlers**

Each handler processes a specific step in the payment workflow:  

- **`DealerControlHandler`**: Performs the dealer validation.  
- **`CommissionControlHandler`**: Checks the commission requirements.  
- **`BankAdapterControlHandler`**: Determines the bank through which the transaction will pass.  
- **`PaymentControlHandler`**: Completes the payment process.  
