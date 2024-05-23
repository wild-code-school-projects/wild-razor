# wild-razor
Learn to separate the logic from the view using asp.net.

## Objective

To ensure that the data handling in the application is managed appropriately by adhering to the best practices for MVC (Model-View-Controller) architecture, specifically focusing on the separation of concerns between the controller and the view.

## Validation Criteria

1. **Controller Data Handling**
    - The controller is responsible for processing data before sending it to the view.
    - Ensure that all data manipulation and preparation logic is contained within the controller.
    - The view should receive pre-processed data from the controller, ready for rendering.

2. **View Logic Constraints**
    - The view (i.e., `.cshtml` file) should not contain any conditions or loops.
    - All conditional logic and iteration should be handled within the controller or the model.
    - The view should only focus on presenting the data provided by the controller.



![image](https://image.noelshack.com/fichiers/2024/21/4/1716448302-screenshot-2024-05-23-091018.png)
