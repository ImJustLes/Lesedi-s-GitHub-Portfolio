package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;
import lombok.*;

@Entity
@Table

//Annotations to eliminate boilerplate code for the model class
@NoArgsConstructor
@AllArgsConstructor
@Setter
@Getter
@ToString
public class DisposalGuideline {

    //Properties with springboot validation error handling.
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    @NotBlank(message = "Description is required")
    @Size(min = 10, max = 500, message = "Description must be between 10 and 500 characters")
    private String description;

    @NotBlank(message = "Type is required")
    @Size(min = 2, max = 50, message = "Type must be between 2 and 50 characters")
    private String type;
}
