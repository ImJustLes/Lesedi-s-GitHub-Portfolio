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
public class Waste {

    //Properties with springboot validation error handling.
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    @NotBlank(message = "Name is required")
    @Size(min = 2, max = 50, message = "Name must be between 2 and 50 characters")
    private String name;

    @NotBlank(message = "Type is required")
    @Pattern(regexp = "^[a-zA-Z]+$", message = "Type must contain only letters")
    private String type;

    @NotNull(message = "Weight is required")
    @DecimalMin(value = "0.1", message = "Weight must be greater than or equal to 0.1")
    @Max(value = 1000, message = "Weight must be less than or equal to 1000")
    private double weight;
}