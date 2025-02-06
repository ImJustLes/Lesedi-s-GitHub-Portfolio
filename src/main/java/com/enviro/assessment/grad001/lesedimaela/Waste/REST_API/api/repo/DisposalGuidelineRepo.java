package com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.repo;

import com.enviro.assessment.grad001.lesedimaela.Waste.REST_API.api.model.DisposalGuideline;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

//Repo used to make database operations for the Disposal Guidelines table
@Repository
public interface DisposalGuidelineRepo extends JpaRepository<DisposalGuideline, Long> {
}
