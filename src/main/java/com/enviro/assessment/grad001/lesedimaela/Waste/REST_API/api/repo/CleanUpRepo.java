package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.CleanUp;
import org.springframework.data.jpa.repository.JpaRepository;

//Repo used to make database operations for the Clean-Up table
public interface CleanUpRepo extends JpaRepository<CleanUp, Long> {
}
