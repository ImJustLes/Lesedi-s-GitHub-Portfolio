package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model;

import jakarta.persistence.*;
import jakarta.validation.constraints.*;
import lombok.*;

@Entity
@Table

//Annotations to eliminate boilerplate code for the model class
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class CleanUp {

    //Properties with springboot validation error handling.
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    @NotBlank(message = "Location is required")
    @Size(min = 5, max = 100, message = "Location must be between 5 and 100 characters")
    private String location;

    @NotBlank(message = "Description is required")
    @Size(min = 10, max = 500, message = "Description must be between 10 and 500 characters")
    private String description;

    @NotNull(message = "Total junk is required")
    @DecimalMin(value = "0.1", message = "Total junk must be greater than or equal to 0")
    private double totalJunk;

    @NotNull(message = "Collected junk is required")
    @DecimalMin(value = "0.1", message = "Collected junk must be greater than or equal to 0")
    private double collectedJunk;
}
